using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using KBJK_Control.Controles;

namespace KBJK_Control.Telas.Dashboard
{
    public partial class ucDashboard : UserControl
    {
        private readonly uint _usuarioId;
        public ucDashboard()
        {
            InitializeComponent();
            AnimacaoUI.AplicarHoverBotoes(this);
            EstiloTabela.Aplicar(dgvVisitasHoje);
            EstiloTabela.AplicarBotao(btnRegistrarEntrada);
            EstiloTabela.AplicarBotao(btnCadastrarVisitante);
            btnCadastrarVisitante.Click += AbrirCadastro;
            btnRegistrarEntrada.Click += AbrirRegistroEntrada;
            pnlPresentes.SizeChanged += (_, _) => AplicarBordasArredondadas();
            pnlEntradas.SizeChanged += (_, _) => AplicarBordasArredondadas();
            pnlCadastros.SizeChanged += (_, _) => AplicarBordasArredondadas();
            dgvVisitasHoje.AutoGenerateColumns = false;
            colVisitante.DataPropertyName = "visitante";
            colEmpresa.DataPropertyName = "empresa_origem";
            colDestino.DataPropertyName = "destino";
            colEntrada.DataPropertyName = "data_entrada";
            colSaida.DataPropertyName = "data_saida";
            colSituacao.DataPropertyName = "situacao";
            Load += (_, _) =>
            {
                if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
                    Carregar();
            };
            Resize += (_, _) => AplicarBordasArredondadas();
            HandleCreated += (_, _) => AplicarBordasArredondadas();
        }

        private void AplicarBordasArredondadas()
        {
            AtualizarRegiao(pnlPresentes);
            AtualizarRegiao(pnlEntradas);
            AtualizarRegiao(pnlCadastros);
        }

        private static void AtualizarRegiao(Panel painel)
        {
            if (painel.ClientSize.Width < 2 || painel.ClientSize.Height < 2)
                return;

            Region? regiaoAnterior = painel.Region;
            painel.Region = CriarRegiaoArredondada(painel.ClientRectangle, 12);
            regiaoAnterior?.Dispose();
        }

        private static Region CriarRegiaoArredondada(Rectangle area, int raio)
        {
            using GraphicsPath caminho = new GraphicsPath();
            int diametro = raio * 2;
            caminho.AddArc(area.Left, area.Top, diametro, diametro, 180, 90);
            caminho.AddArc(area.Right - diametro, area.Top, diametro, diametro, 270, 90);
            caminho.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            caminho.AddArc(area.Left, area.Bottom - diametro, diametro, diametro, 90, 90);
            caminho.CloseFigure();
            return new Region(caminho);
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

                var visitasHoje = repo.Listar(
                    inicio: DateTime.Today,
                    fim: DateTime.Today);

                // A seção se chama "Visitas recentes". Ela não deve sumir
                // quando ainda não houve uma entrada na data atual; os cartões
                // abaixo continuam sendo os indicadores exclusivos de hoje.
                dgvVisitasHoje.DataSource = repo.Listar();
                dgvVisitasHoje.ClearSelection();

                lblTotalPresentes.Text = repo.Listar(
                    situacao: "EM ANDAMENTO")
                    .Rows.Count
                    .ToString();

                lblTotalEntradas.Text = visitasHoje.Rows.Count.ToString();

                lblTotalCadastros.Text = new VisitanteRepository()
                    .ContarCadastrosHoje()
                    .ToString();
            }
            catch (MySqlConnector.MySqlException)
            {
                MessageBox.Show(
                    "Não foi possível carregar os dados do Dashboard.",
                    "Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
