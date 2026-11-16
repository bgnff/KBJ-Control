using System;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Visitantes
{
    public partial class ucVisitantes : UserControl
    {
        private readonly VisitanteRepository _repository = new();

        public ucVisitantes()
        {
            InitializeComponent();

            ConfigurarTabela();

            Load += ucVisitantes_Load;
            btnPesquisarVisitantes.Click += btnPesquisarVisitantes_Click;
            txtPesquisaVisitantes.KeyDown += txtPesquisaVisitantes_KeyDown;
            btnCadastrarVisitante.Click += btnCadastrarVisitante_Click;
        }

        private void btnCadastrarVisitante_Click(object? sender, EventArgs e)
        {
            using var tela = new KBJK_Control.Telas.Dashboard.FrmCadastrarVisitante();
            if (tela.ShowDialog(FindForm()) == DialogResult.OK)
                CarregarVisitantes();
        }

        private void ConfigurarTabela()
        {
            // Usa somente as colunas que você criou no Designer.
            dgvVisitantes.AutoGenerateColumns = false;

            dgvVisitantes.Columns["colNome"].DataPropertyName =
                "nome_completo";

            dgvVisitantes.Columns["colDocumento"].DataPropertyName =
                "documento";

            dgvVisitantes.Columns["colEmpresa"].DataPropertyName =
                "empresa_origem";

            dgvVisitantes.Columns["colEmpresa"].HeaderText =
                "Empresa da última visita";

            dgvVisitantes.Columns["colEmpresa"]
                .DefaultCellStyle.NullValue = "—";
        }

        private void ucVisitantes_Load(object sender, EventArgs e)
        {
            CarregarVisitantes();
        }

        private void CarregarVisitantes()
        {
            try
            {
                var tabela = _repository.Listar(
                    txtPesquisaVisitantes.Text);

                dgvVisitantes.DataSource = tabela;

                lblTotalVisitantes.Text =
                    $"Visitantes encontrados: {tabela.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os visitantes.\n\n"
                    + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarVisitantes_Click(
            object sender, EventArgs e)
        {
            CarregarVisitantes();
        }

        private void txtPesquisaVisitantes_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CarregarVisitantes();
            }
        }
    }
}
