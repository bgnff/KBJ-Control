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
    public partial class ucDashboard : UserControl
    {
        private readonly uint _usuarioId;
        public ucDashboard()
        {
            InitializeComponent();
            btnCadastrarVisitante.Click += AbrirCadastro;
            btnRegistrarEntrada.Click += AbrirRegistroEntrada;
            dgvVisitasHoje.AutoGenerateColumns = false;
            colVisitante.DataPropertyName = "visitante";
            colEmpresa.DataPropertyName = "empresa_origem";
            colDestino.DataPropertyName = "destino";
            colEntrada.DataPropertyName = "data_entrada";
            colSaida.DataPropertyName = "data_saida";
            colSituacao.DataPropertyName = "situacao";
            Load += (_, _) => { if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) Carregar(); };
        }

        public ucDashboard(uint usuarioId) : this() => _usuarioId = usuarioId;

        private void AbrirCadastro(object? sender, EventArgs e)
        {
            using var tela = new FrmCadastrarVisitante();
            if (tela.ShowDialog(FindForm()) == DialogResult.OK) Carregar();
        }

        private void AbrirRegistroEntrada(object? sender, EventArgs e)
        {
            using var tela = new KBJK_Control.Telas.Tela_RegistrarEntrada.frmRegistrarEntrada(_usuarioId);
            if (tela.ShowDialog(FindForm()) == DialogResult.OK) Carregar();
        }

        private void Carregar()
        {
            try
            {
                var repo = new VisitaRepository();
                var hoje = repo.Listar(inicio: DateTime.Today, fim: DateTime.Today);
                dgvVisitasHoje.DataSource = hoje;
                lblTotalPresentes.Text = repo.Listar(situacao: "EM ANDAMENTO").Rows.Count.ToString();
                using var conexao = ConexaoBD.ObterConexao();
                using var comando = conexao.CreateCommand();
                comando.CommandText = "SELECT (SELECT COUNT(*) FROM visitas WHERE data_entrada >= CURDATE() AND data_entrada < CURDATE() + INTERVAL 1 DAY), (SELECT COUNT(*) FROM visitas WHERE data_saida >= CURDATE() AND data_saida < CURDATE() + INTERVAL 1 DAY), (SELECT COUNT(*) FROM visitantes WHERE data_registro >= CURDATE() AND data_registro < CURDATE() + INTERVAL 1 DAY)";
                conexao.Open();
                using var leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    lblTotalEntradas.Text = leitor.GetInt64(0).ToString();
                    lblTotalSaidas.Text = leitor.GetInt64(1).ToString();
                    lblTotalCadastros.Text = leitor.GetInt64(2).ToString();
                }
            }
            catch (MySqlConnector.MySqlException)
            {
                dgvVisitasHoje.DataSource = null;
                lblTotalPresentes.Text = lblTotalEntradas.Text = lblTotalSaidas.Text = lblTotalCadastros.Text = "—";
                lblDescricaoDashboard.Text = "Não foi possível carregar os dados. Verifique a conexão.";
            }
        }

        private void dgvVisitasHoje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvVisitasHoje.Columns[e.ColumnIndex].Name == "colDetalhes")
            {
                var linha = dgvVisitasHoje.Rows[e.RowIndex];

                if (linha.DataBoundItem is System.Data.DataRowView visita)
                    MessageBox.Show($"Visitante: {visita["visitante"]}\nDocumento: {visita["documento"]}\nDestino: {visita["destino"]}\nEntrada: {visita["data_entrada"]}\nSaída: {visita["data_saida"]}\nMotivo: {visita["motivo_visita"]}\nObservações: {visita["observacoes"]}", "Detalhes da visita");
            }
        }

        private void PintarBordaCartao(object sender, PaintEventArgs e)
        {
            if (sender is not Panel painel)
                return;

            using (var caneta = new Pen(Color.FromArgb(212, 217, 223)))
            {
                e.Graphics.DrawRectangle(
                    caneta,
                    0,
                    0,
                    painel.ClientSize.Width - 1,
                    painel.ClientSize.Height - 1);
            }
        }

        private void dgvVisitasHoje_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvVisitasHoje.Columns[e.ColumnIndex].Name != "colSituacao")
                return;

            string situacao = Convert.ToString(e.Value)?.Trim() ?? "";

            Color cor = dgvVisitasHoje.DefaultCellStyle.ForeColor;

            if (situacao.Equals(
                "Em andamento",
                StringComparison.OrdinalIgnoreCase))
            {
                cor = Color.FromArgb(40, 100, 71);
            }
            else if (situacao.Equals(
                "Encerrada",
                StringComparison.OrdinalIgnoreCase))
            {
                cor = Color.FromArgb(180, 45, 45);
            }

            e.CellStyle.ForeColor = cor;
            e.CellStyle.SelectionForeColor = cor;
        }
    }
}
