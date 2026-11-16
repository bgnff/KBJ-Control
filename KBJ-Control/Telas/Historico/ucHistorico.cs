using System.Data;

namespace KBJK_Control.Telas.Historico
{
    public partial class ucHistorico : UserControl
    {
        private readonly VisitaRepository _repository = new();
        public ucHistorico()
        {
            InitializeComponent();
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
            dgvHistorico.CellContentClick += MostrarDetalhes;
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
        private void cmbSituacaoHistorico_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
