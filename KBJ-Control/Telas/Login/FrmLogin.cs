using KBJK_Control.Telas.Inicial;
using KBJK_Control.Telas.Principal;
using MySqlConnector;

namespace KBJK_Control
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tlpCentral_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tlpCentral_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show(
                    "Por favor, preencha o usuário e a senha.",
                    "Campos obrigatórios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                UsuarioRepository repo = new UsuarioRepository();
                bool loginSucesso = repo.AutentificarUsuario(usuario, senha);

                if (loginSucesso)
                {
                    this.Hide();

                    using (var telaPrincipal = new FrmPrincipal())
                    {
                        telaPrincipal.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Usuário ou senha incorretos ou inexistentes.",
                        "Falha no login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro no sistema: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblPreencha_Click(object sender, EventArgs e)
        {
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
        }
    }
}