using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Tela_RegistrarEntrada
{
    public partial class frmRegistrarEntrada : Form
    {
        private readonly uint _usuarioId;
        public frmRegistrarEntrada()
        {
            InitializeComponent();
            dgvVisitantes.ReadOnly = true;
            dgvVisitantes.MultiSelect = false;
            dgvVisitantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitantes.AllowUserToAddRows = false;
            txtPessoaSetorVisitado.MaxLength = 150;
            txtMotivo.MaxLength = 255;
            dgvVisitantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load += (_, _) => { if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) CarregarVisitantes(); };
            btnConfirmarEntrada.Click += ConfirmarEntrada;
            btnCancelar.Click += (_, _) => Close();
            btnCadastrarNVisitante.Click += (_, _) =>
            {
                using var cadastro = new KBJK_Control.Telas.Dashboard.FrmCadastrarVisitante();
                if (cadastro.ShowDialog(this) == DialogResult.OK) CarregarVisitantes();
            };
        }

        public frmRegistrarEntrada(uint usuarioId) : this() => _usuarioId = usuarioId;

        private void CarregarVisitantes()
        {
            try
            {
                dgvVisitantes.DataSource = new VisitanteRepository().Listar(textBox1.Text);
                dgvVisitantes.Columns["visitante_id"].Visible = false;
                dgvVisitantes.ClearSelection();
            }
            catch (MySqlConnector.MySqlException)
            {
                MessageBox.Show("Não foi possível consultar os visitantes. Verifique a conexão com o banco.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmarEntrada(object? sender, EventArgs e)
        {
            if (_usuarioId == 0 || dgvVisitantes.SelectedRows.Count != 1 || string.IsNullOrWhiteSpace(txtPessoaSetorVisitado.Text) || cmbMotivo.SelectedItem is not string motivo)
            {
                MessageBox.Show("Selecione um visitante e informe o destino e o motivo da visita.", "Dados obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using var conexao = ConexaoBD.ObterConexao();
                using var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO visitas (visitante_id, empresa_origem, destino, usuario_entrada_id, motivo_visita, observacoes) VALUES (@visitante, @empresa, @destino, @usuario, @motivo, @observacoes)";
                comando.Parameters.AddWithValue("@visitante", Convert.ToUInt32(dgvVisitantes.SelectedRows[0].Cells["visitante_id"].Value));
                comando.Parameters.AddWithValue("@empresa", string.IsNullOrWhiteSpace(txtEmpresa.Text) ? DBNull.Value : txtEmpresa.Text.Trim());
                comando.Parameters.AddWithValue("@destino", txtPessoaSetorVisitado.Text.Trim());
                comando.Parameters.AddWithValue("@usuario", _usuarioId);
                comando.Parameters.AddWithValue("@motivo", motivo);
                comando.Parameters.AddWithValue("@observacoes", string.IsNullOrWhiteSpace(txtMotivo.Text) ? DBNull.Value : txtMotivo.Text.Trim());
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Entrada registrada com sucesso.", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlConnector.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Este visitante já possui uma visita em andamento.", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlConnector.MySqlException)
            {
                MessageBox.Show("Não foi possível registrar a entrada. Verifique os dados e a conexão.", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscarVisitante_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated) CarregarVisitantes();
        }

        private void lblPessoaSetor_Click(object sender, EventArgs e)
        {

        }
    }
}
