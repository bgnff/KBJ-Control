using System.Data;
using KBJK_Control.Telas.Tela_RegistrarEntrada;

namespace KBJK_Control.Telas.Recepcao
{
    public partial class ucRecepcao : UserControl
    {
        private readonly uint _usuarioId;
        private readonly VisitaRepository _repository = new();
        public ucRecepcao()
        {
            InitializeComponent();
            dgvPresentes.AutoGenerateColumns = false;
            colVisitante.DataPropertyName = "visitante";
            colDocumento.DataPropertyName = "documento";
            colEmpresa.DataPropertyName = "empresa_origem";
            colDestino.DataPropertyName = "destino";
            colEntrada.DataPropertyName = "data_entrada";
            Load += (_, _) => { if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) Carregar(); };
            btnPesquisar.Click += (_, _) => Carregar();
            btnREntrada.Click += (_, _) => { using var tela = new frmRegistrarEntrada(_usuarioId); if (tela.ShowDialog(FindForm()) == DialogResult.OK) Carregar(); };
            dgvPresentes.CellContentClick += RegistrarSaida;
        }
        public ucRecepcao(uint usuarioId) : this() => _usuarioId = usuarioId;

        private void Carregar()
        {
            try
            {
                var dados = _repository.Listar(txtPesquisa.Text, situacao: "EM ANDAMENTO");
                dgvPresentes.DataSource = dados;
                lblTotalPresentes.Text = $"Visitantes presentes: {dados.Rows.Count}";
            }
            catch (MySqlConnector.MySqlException)
            {
                dgvPresentes.DataSource = null;
                lblTotalPresentes.Text = "Não foi possível consultar os presentes.";
                MessageBox.Show("Não foi possível consultar as visitas. Verifique a conexão com o banco.", "Recepção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegistrarSaida(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colSaida.Index || dgvPresentes.Rows[e.RowIndex].DataBoundItem is not DataRowView linha) return;
            if (_usuarioId == 0) { MessageBox.Show("Entre no sistema para registrar a saída."); return; }
            var nome = Convert.ToString(linha["visitante"]);
            if (MessageBox.Show($"Registrar a saída de {nome}?", "Confirmar saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                bool alterada = _repository.RegistrarSaida(Convert.ToUInt32(linha["visita_id"]), _usuarioId);
                MessageBox.Show(alterada ? "Saída registrada." : "Esta visita já foi encerrada.", "Recepção");
                Carregar();
            }
            catch (MySqlConnector.MySqlException) { MessageBox.Show("Não foi possível registrar a saída. Verifique a conexão.", "Recepção", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e) { }
    }
}
