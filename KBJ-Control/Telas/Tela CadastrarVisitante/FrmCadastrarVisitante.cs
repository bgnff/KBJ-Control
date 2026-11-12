using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Dashboard
{
    public partial class FrmCadastrarVisitante : Form
    {
        public FrmCadastrarVisitante()
        {
            InitializeComponent();
            cbxTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoDocumento.Items.AddRange(new object[] { "RG", "CPF", "PASSAPORTE" });
            cbxEmissor.Items.Add("Brasil");
            cbxEmissor.Text = "Brasil";
            txtNome.MaxLength = 30;
            txtSobrenome.MaxLength = 30;
            textBox1.MaxLength = 20;
            cbxEmissor.MaxLength = 30;
            btnCancelar.Click += (_, _) => Close();
            btnSalvarCadastro.Click += SalvarCadastro;
            AcceptButton = btnSalvarCadastro;
            CancelButton = btnCancelar;
        }

        private void SalvarCadastro(object? sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            var sobrenome = txtSobrenome.Text.Trim();
            var documento = textBox1.Text.Trim();
            var pais = cbxEmissor.Text.Trim();
            if (nome.Length == 0 || sobrenome.Length == 0 || cbxTipoDocumento.SelectedItem is not string tipo || documento.Length == 0 || pais.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Cadastro de visitante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                new VisitanteRepository().Cadastrar(nome, sobrenome, tipo, documento, pais);
                MessageBox.Show("Visitante cadastrado com sucesso.", "Cadastro de visitante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlConnector.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um visitante com esse documento e país emissor.", "Documento já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlConnector.MySqlException)
            {
                MessageBox.Show("Não foi possível salvar o visitante. Verifique a conexão com o banco e tente novamente.", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNomeCadastro1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
