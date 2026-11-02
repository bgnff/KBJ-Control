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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("Por favor, preencha o usuário e a senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuarioRepository repo = new UsuarioRepository();
                bool loginSucesso = repo.AutentificarUsuario(usuario, senha);

                if (loginSucesso)
                {
                    //APENAS PARA TESTAR, NÃO TEM TELA INICIAL
                    this.Hide();

                    using (var telaPrincipal = new FrmPrincipal())
                    {
                        telaPrincipal.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos ou inexistentes.", "Falha no LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no sistema: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
