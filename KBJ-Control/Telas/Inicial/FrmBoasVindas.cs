using System.Runtime.InteropServices;

namespace KBJK_Control.Telas.Inicial
{
    public partial class FrmBoasVindas : Form
    {
        private const int WmNclbuttondown = 0x00A1;
        private const int HtCaption = 0x0002;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public FrmBoasVindas()
        {
            InitializeComponent();
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {
            AtualizarEstadoMaximizar();
            AplicarCantosArredondados(btnIniciar, 8);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Hide();
            using var login = new frmLogin();
            login.ShowDialog();
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;

        private void btnMaximizar_Click(object sender, EventArgs e) => AlternarMaximizacao();

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(196, 43, 28);
            btnFechar.ForeColor = Color.White;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.White;
            btnFechar.ForeColor = Color.FromArgb(48, 55, 65);
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, IntPtr.Zero);
        }

        private void pnlBarraTitulo_DoubleClick(object sender, EventArgs e) => AlternarMaximizacao();

        private void FrmBoasVindas_Resize(object sender, EventArgs e)
        {
            AtualizarEstadoMaximizar();
            AplicarCantosArredondados(btnIniciar, 8);
        }

        private void AlternarMaximizacao()
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void AtualizarEstadoMaximizar() =>
            btnMaximizar.Text = WindowState == FormWindowState.Maximized ? "❐" : "□";

        private static void AplicarCantosArredondados(Control controle, int raio)
        {
            if (controle.Width <= 0 || controle.Height <= 0) return;

            using var caminho = new System.Drawing.Drawing2D.GraphicsPath();
            int diametro = raio * 2;
            var arco = new Rectangle(0, 0, diametro, diametro);
            caminho.AddArc(arco, 180, 90);
            arco.X = controle.Width - diametro - 1;
            caminho.AddArc(arco, 270, 90);
            arco.Y = controle.Height - diametro - 1;
            caminho.AddArc(arco, 0, 90);
            arco.X = 0;
            caminho.AddArc(arco, 90, 90);
            caminho.CloseFigure();

            controle.Region?.Dispose();
            controle.Region = new Region(caminho);
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            using var caneta = new Pen(Color.FromArgb(212, 217, 223));
            int y = pnlBarraTitulo.ClientSize.Height - 1;
            e.Graphics.DrawLine(caneta, 0, y, pnlBarraTitulo.ClientSize.Width, y);
        }

        private void pnlBarraStatus_Paint(object sender, PaintEventArgs e)
        {
            using var caneta = new Pen(Color.FromArgb(212, 217, 223));
            e.Graphics.DrawLine(caneta, 0, 0, pnlBarraStatus.ClientSize.Width, 0);
        }

        private void tlpImagemInicial_Paint(object sender, PaintEventArgs e)
        {
            using var caneta = new Pen(Color.FromArgb(232, 185, 63), 2F);
            int x = tlpImagemInicial.ClientSize.Width - 1;
            e.Graphics.DrawLine(caneta, x, 0, x, tlpImagemInicial.ClientSize.Height);
        }

        private void lblInstrucao_Click(object sender, EventArgs e)
        {

        }
    }
}
