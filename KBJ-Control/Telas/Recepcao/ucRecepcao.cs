using System.Data;
using System.Drawing.Drawing2D;
using KBJK_Control.Controles;
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
            AnimacaoUI.AplicarHoverBotoes(this);
            EstiloTabela.Aplicar(dgvPresentes);
            EstiloTabela.AplicarCampo(txtPesquisa);
            EstiloTabela.AplicarBotao(btnPesquisarRecepcao2);
            EstiloTabela.AplicarBotao(btnREntrada);
            dgvPresentes.AutoGenerateColumns = false;
            colVisitante.DataPropertyName = "visitante";
            colDocumento.DataPropertyName = "documento";
            colEmpresa.DataPropertyName = "empresa_origem";
            colDestino.DataPropertyName = "destino";
            colEntrada.DataPropertyName = "data_entrada";
            colSituacao.DataPropertyName = "situacao";
            Load += (_, _) => { if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) Carregar(); };
            btnPesquisarRecepcao2.Click += (_, _) => Carregar();
            btnREntrada.Click += (_, _) => { using var tela = new frmRegistrarEntrada(_usuarioId); if (tela.ShowDialog(FindForm()) == DialogResult.OK) Carregar(); };
            dgvPresentes.CellContentClick += RegistrarSaida;
            dgvPresentes.CellFormatting += DestacarSituacao;
            Resize += (_, _) => AplicarBordasArredondadas();
            HandleCreated += (_, _) => AplicarBordasArredondadas();
        }
        public ucRecepcao(uint usuarioId) : this() => _usuarioId = usuarioId;

        private void AplicarBordasArredondadas()
        {
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
        private void DestacarSituacao(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colSituacao.Index) return;
            string situacao = Convert.ToString(e.Value) ?? string.Empty;
            if (situacao.Equals("Em andamento", StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.BackColor = Color.FromArgb(230, 244, 237);
                e.CellStyle.ForeColor = Color.FromArgb(26, 112, 75);
                e.CellStyle.SelectionBackColor = Color.FromArgb(230, 244, 237);
                e.CellStyle.SelectionForeColor = Color.FromArgb(26, 112, 75);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e) { }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvPresentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisarRecepcao2_Click(object sender, EventArgs e)
        {

        }
    }
}
