using System.Data;
using System.Drawing.Drawing2D;
using KBJK_Control.Controles;

namespace KBJK_Control.Telas.Historico
{
    public partial class ucHistorico : UserControl
    {
        private readonly VisitaRepository _repository = new();
        public ucHistorico()
        {
            InitializeComponent();
            KBJK_Control.Controles.AnimacaoUI.AplicarHoverBotoes(this);
            EstiloTabela.Aplicar(dgvHistorico);
            EstiloTabela.AplicarCampo(txtPesquisaHistorico);
            EstiloTabela.AplicarCampo(dtpDataInicial);
            EstiloTabela.AplicarCampo(dtpDataFinal);
            EstiloTabela.AplicarCampo(cmbSituacaoHistorico);
            dgvHistorico.AutoGenerateColumns = false;
            colVisitante.DataPropertyName = "visitante";
            colDocumento.DataPropertyName = "documento";
            colEmpresa.DataPropertyName = "empresa_origem";
            colDestino.DataPropertyName = "destino";
            colEntrada.DataPropertyName = "data_entrada";
            colSaida.DataPropertyName = "data_saida";
            colSituacao.DataPropertyName = "situacao";
            cmbSituacaoHistorico.SelectedIndex = 0;
            dtpDataInicial.Value = DateTime.Today.AddDays(-30);
            Load += (_, _) => { if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) Carregar(); };
            btnFiltrarHistorico.Click += (_, _) => Carregar();
            btnLimparFiltros.Click += LimparFiltros;
            txtPesquisaHistorico.KeyDown += (_, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.SuppressKeyPress = true;
                Carregar();
            };
            dtpDataInicial.ValueChanged += (_, _) => AtualizarFiltroAutomatico();
            dtpDataFinal.ValueChanged += (_, _) => AtualizarFiltroAutomatico();
            dgvHistorico.CellContentClick += MostrarDetalhes;
            dgvHistorico.CellPainting += DesenharSituacao;
            Resize += (_, _) => AplicarBordasArredondadas();
            HandleCreated += (_, _) => AplicarBordasArredondadas();
        }

        private void LimparFiltros(object? sender, EventArgs e)
        {
            txtPesquisaHistorico.Clear();
            dtpDataInicial.Value = DateTime.Today.AddDays(-30);
            dtpDataFinal.Value = DateTime.Today;
            cmbSituacaoHistorico.SelectedIndex = 0;
            Carregar();
        }

        private void AtualizarFiltroAutomatico()
        {
            if (IsHandleCreated)
                Carregar();
        }

        private void AplicarBordasArredondadas()
        {
            tlpFiltrosHistorico.Region = CriarRegiaoArredondada(tlpFiltrosHistorico.ClientRectangle, 12);
        }

        private void DesenharSituacao(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colSituacao.Index)
                return;

            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
            string texto = Convert.ToString(e.FormattedValue) ?? string.Empty;
            bool emAndamento = texto.Equals("Em andamento", StringComparison.OrdinalIgnoreCase);
            Color fundo = emAndamento ? Color.FromArgb(230, 244, 237) : Color.FromArgb(239, 242, 246);
            Color fonte = emAndamento ? Color.FromArgb(26, 112, 75) : Color.FromArgb(82, 101, 124);
            Size tamanho = TextRenderer.MeasureText(texto, e.CellStyle.Font);
            Rectangle selo = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + Math.Max(4, (e.CellBounds.Height - 26) / 2), tamanho.Width + 16, 26);
            using GraphicsPath caminho = CriarCaminhoArredondado(selo, 13);
            using SolidBrush pincel = new SolidBrush(fundo);
            e.Graphics.FillPath(pincel, caminho);
            TextRenderer.DrawText(e.Graphics, texto, e.CellStyle.Font, new Point(selo.X + 8, selo.Y + 5), fonte);
            e.Handled = true;
        }

        private static Region CriarRegiaoArredondada(Rectangle area, int raio) => new Region(CriarCaminhoArredondado(area, raio));

        private static GraphicsPath CriarCaminhoArredondado(Rectangle area, int raio)
        {
            GraphicsPath caminho = new GraphicsPath();
            int diametro = raio * 2;
            caminho.AddArc(area.Left, area.Top, diametro, diametro, 180, 90);
            caminho.AddArc(area.Right - diametro, area.Top, diametro, diametro, 270, 90);
            caminho.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            caminho.AddArc(area.Left, area.Bottom - diametro, diametro, diametro, 90, 90);
            caminho.CloseFigure();
            return caminho;
        }
        private void Carregar()
        {
            if (dtpDataInicial.Value.Date > dtpDataFinal.Value.Date)
            {
                MessageBox.Show("A data inicial deve ser anterior ou igual à data final.", "Período inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string? situacao = cmbSituacaoHistorico.SelectedIndex switch { 1 => "EM ANDAMENTO", 2 => "ENCERRADA", _ => null };
            try
            {
                var dados = _repository.Listar(txtPesquisaHistorico.Text, dtpDataInicial.Value, dtpDataFinal.Value, situacao);
                dgvHistorico.DataSource = dados;
                label1.Text = $"Visitas encontradas: {dados.Rows.Count}";
            }
            catch (MySqlConnector.MySqlException)
            {
                dgvHistorico.DataSource = null;
                label1.Text = "Não foi possível consultar as visitas.";
                MessageBox.Show("Verifique a conexão com o banco.", "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarDetalhes(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colDetalhes.Index || dgvHistorico.Rows[e.RowIndex].DataBoundItem is not DataRowView linha) return;
            MessageBox.Show($"Visitante: {linha["visitante"]}\nDocumento: {linha["documento"]}\nEmpresa: {linha["empresa_origem"]}\nDestino: {linha["destino"]}\nEntrada: {linha["data_entrada"]}\nSaída: {linha["data_saida"]}\nMotivo: {linha["motivo_visita"]}\nObservações: {linha["observacoes"]}", "Detalhes da visita");
        }
        private void dgvHistorico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colSituacao.Index || e.CellStyle is null) return;
            string situacao = Convert.ToString(e.Value) ?? "";
            e.CellStyle.ForeColor = situacao.Equals("Em andamento", StringComparison.OrdinalIgnoreCase) ? Color.FromArgb(40, 100, 71) : Color.FromArgb(90, 103, 123);
        }
        private void cmbSituacaoHistorico_SelectedIndexChanged(object sender, EventArgs e) => AtualizarFiltroAutomatico();
    }
}
