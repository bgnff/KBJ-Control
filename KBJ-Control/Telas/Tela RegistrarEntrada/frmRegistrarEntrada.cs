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
using System.Runtime.InteropServices;
using KBJK_Control.Controles;

namespace KBJK_Control.Telas.Tela_RegistrarEntrada
{
    public partial class frmRegistrarEntrada : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private readonly uint _usuarioId;
        public frmRegistrarEntrada()
        {
            InitializeComponent();
            Icon = IconeAplicacao.Criar();
            AnimacaoUI.AplicarHoverBotoes(this);
            AnimacaoUI.AnimarAbertura(this);
            EstiloTabela.Aplicar(dgvVisitantes);
            dgvVisitantes.ReadOnly = true;
            dgvVisitantes.MultiSelect = false;
            dgvVisitantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitantes.AllowUserToAddRows = false;
            txtPessoaSetorVisitado.MaxLength = 150;
            txtMotivo.MaxLength = 255;
            cmbMotivo.SelectedItem = "OUTROS";
            dgvVisitantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load += (_, _) => { if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime) CarregarVisitantes(); };
            btnConfirmarEntrada.Click += ConfirmarEntrada;
            btnCancelar.Click += (_, _) => Close();
            btnFechar.Click += (_, _) => Close();
            pnlTitulo.MouseDown += MoverJanela;
            lblTitulo.MouseDown += MoverJanela;
            btnCadastrarNVisitante.Click += (_, _) =>
            {
                using var cadastro = new KBJK_Control.Telas.Dashboard.FrmCadastrarVisitante();
                if (cadastro.ShowDialog(this) == DialogResult.OK) CarregarVisitantes();
            };
            Shown += (_, _) =>
            {
                AtualizarLayout();
                AplicarBordasArredondadas();
            };
            Resize += (_, _) =>
            {
                AtualizarLayout();
                AplicarBordasArredondadas();
            };
        }

        /// <summary>
        /// Mantém a composição do formulário proporcional sem depender de
        /// posições fixas. Os controles continuam individuais no Designer.
        /// </summary>
        private void AtualizarLayout()
        {
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            const int margem = 32;
            const int alturaCabecalho = 84;
            const int alturaRodape = 92;
            const int alturaCampo = 40;
            const int alturaBotao = 40;
            const int alturaRotulo = 20;
            const int espacamentoRotulo = 6;

            int larguraConteudo = Math.Max(300, ClientSize.Width - (margem * 2));
            int y = alturaCabecalho + 26;

            pnlTitulo.Height = alturaCabecalho;
            lblTitulo.Location = new Point(margem, 25);
            btnFechar.Size = new Size(32, 32);
            btnFechar.Location = new Point(ClientSize.Width - margem - btnFechar.Width, 25);

            lblBuscarVisitante.Location = new Point(margem, y);
            pnlCampoBusca.Location = new Point(margem, y + alturaRotulo + espacamentoRotulo);
            pnlCampoBusca.Size = new Size(larguraConteudo, alturaCampo);
            ConfigurarCampo(textBox1, pnlCampoBusca);

            int tabelaY = pnlCampoBusca.Bottom + 18;
            int alturaGrade = ClientSize.Height - alturaRodape - tabelaY - 410;
            alturaGrade = Math.Clamp(alturaGrade, 118, 176);
            pnlTabelaVisitantes.Location = new Point(margem, tabelaY);
            pnlTabelaVisitantes.Size = new Size(larguraConteudo, alturaGrade);
            dgvVisitantes.Location = new Point(1, 1);
            dgvVisitantes.Size = new Size(Math.Max(1, pnlTabelaVisitantes.Width - 2), Math.Max(1, pnlTabelaVisitantes.Height - 2));

            pnlBotaoCadastrar.Location = new Point(margem, pnlTabelaVisitantes.Bottom + 18);
            pnlBotaoCadastrar.Size = new Size(218, alturaBotao);

            y = pnlBotaoCadastrar.Bottom + 26;
            OrganizarCampo(lblEmpresa, pnlCampoEmpresa, txtEmpresa, y, larguraConteudo, alturaCampo, alturaRotulo, espacamentoRotulo);
            y = pnlCampoEmpresa.Bottom + 16;
            OrganizarCampo(lblPessoaSetor, pnlCampoDestino, txtPessoaSetorVisitado, y, larguraConteudo, alturaCampo, alturaRotulo, espacamentoRotulo);
            y = pnlCampoDestino.Bottom + 16;
            OrganizarCampo(lblCategoria, pnlCampoCategoria, cmbMotivo, y, larguraConteudo, alturaCampo, alturaRotulo, espacamentoRotulo);
            y = pnlCampoCategoria.Bottom + 16;
            OrganizarCampo(lblMotivo, pnlCampoObservacoes, txtMotivo, y, larguraConteudo, alturaCampo, alturaRotulo, espacamentoRotulo);

            pnlRodape.Height = alturaRodape;
            pnlBotaoCancelar.BackColor = pnlRodape.BackColor;
            pnlBotaoConfirmar.BackColor = pnlRodape.BackColor;
            lblAvisoAutomatico.Location = new Point(margem, (alturaRodape - lblAvisoAutomatico.Height) / 2);

            const int larguraCancelar = 114;
            const int larguraConfirmar = 150;
            const int distanciaBotoes = 12;
            int botoesY = (alturaRodape - alturaBotao) / 2;
            pnlBotaoConfirmar.Size = new Size(larguraConfirmar, alturaBotao);
            pnlBotaoConfirmar.Location = new Point(ClientSize.Width - margem - larguraConfirmar, botoesY);
            pnlBotaoCancelar.Size = new Size(larguraCancelar, alturaBotao);
            pnlBotaoCancelar.Location = new Point(pnlBotaoConfirmar.Left - distanciaBotoes - larguraCancelar, botoesY);
        }

        private static void OrganizarCampo(Label rotulo, Control painel, TextBox campo, int y, int largura, int altura, int alturaRotulo, int espacamento)
        {
            rotulo.Location = new Point(32, y);
            painel.Location = new Point(32, y + alturaRotulo + espacamento);
            painel.Size = new Size(largura, altura);
            ConfigurarCampo(campo, painel);
        }

        private static void ConfigurarCampo(TextBox campo, Control painel)
        {
            campo.BorderStyle = BorderStyle.None;
            campo.Dock = DockStyle.None;
            campo.Location = new Point(12, Math.Max(1, (painel.Height - campo.PreferredHeight) / 2));
            campo.Size = new Size(Math.Max(1, painel.Width - 24), campo.PreferredHeight);
            campo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private static void OrganizarCampo(Label rotulo, Control painel, ComboBox campo, int y, int largura, int altura, int alturaRotulo, int espacamento)
        {
            rotulo.Location = new Point(32, y);
            painel.Location = new Point(32, y + alturaRotulo + espacamento);
            painel.Size = new Size(largura, altura);
            campo.Location = new Point(8, 6);
            campo.Size = new Size(Math.Max(1, painel.Width - 16), 28);
            campo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void AplicarBordasArredondadas()
        {
            Region = CriarRegiaoArredondada(ClientRectangle, 14);
        }

        private void MoverJanela(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
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
            if (_usuarioId == 0 || dgvVisitantes.SelectedRows.Count != 1 || string.IsNullOrWhiteSpace(txtPessoaSetorVisitado.Text))
            {
                MessageBox.Show("Selecione um visitante e informe o destino e o motivo da visita.", "Dados obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string motivo = Convert.ToString(cmbMotivo.SelectedItem) ?? "OUTROS";
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
