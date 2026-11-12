namespace KBJK_Control.Telas.Inicial
{
    partial class FrmBoasVindas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoasVindas));
            tlpEstrutura = new TableLayoutPanel();
            pnlBarraTitulo = new Panel();
            flpIdentidadeJanela = new FlowLayoutPanel();
            picLogoTitulo = new PictureBox();
            lblNomeJanela = new Label();
            flpControlesJanela = new FlowLayoutPanel();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnFechar = new Button();
            tlpAreaBoasVindas = new TableLayoutPanel();
            tlpConteudoCentral = new TableLayoutPanel();
            picLogo = new PictureBox();
            flpNomeApp = new FlowLayoutPanel();
            lblMarcaKbj = new Label();
            lblMarcaControl = new Label();
            lblInstrucao = new Label();
            btnIniciar = new Button();
            lblBoasVindas = new Label();
            tlpImagemInicial = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pnlBarraStatus = new Panel();
            lblStatusContexto = new Label();
            lblStatusAmbiente = new Label();
            tlpEstrutura.SuspendLayout();
            pnlBarraTitulo.SuspendLayout();
            flpIdentidadeJanela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoTitulo).BeginInit();
            flpControlesJanela.SuspendLayout();
            tlpAreaBoasVindas.SuspendLayout();
            tlpConteudoCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            flpNomeApp.SuspendLayout();
            tlpImagemInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBarraStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tlpEstrutura
            // 
            tlpEstrutura.BackColor = Color.FromArgb(20, 34, 55);
            tlpEstrutura.ColumnCount = 1;
            tlpEstrutura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstrutura.Controls.Add(pnlBarraTitulo, 0, 0);
            tlpEstrutura.Controls.Add(tlpAreaBoasVindas, 0, 1);
            tlpEstrutura.Controls.Add(pnlBarraStatus, 0, 2);
            tlpEstrutura.Dock = DockStyle.Fill;
            tlpEstrutura.Location = new Point(0, 0);
            tlpEstrutura.Margin = new Padding(0);
            tlpEstrutura.Name = "tlpEstrutura";
            tlpEstrutura.RowCount = 3;
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpEstrutura.Size = new Size(1366, 768);
            tlpEstrutura.TabIndex = 0;
            // 
            // pnlBarraTitulo
            // 
            pnlBarraTitulo.BackColor = Color.White;
            pnlBarraTitulo.Controls.Add(flpIdentidadeJanela);
            pnlBarraTitulo.Controls.Add(flpControlesJanela);
            pnlBarraTitulo.Dock = DockStyle.Fill;
            pnlBarraTitulo.Location = new Point(0, 0);
            pnlBarraTitulo.Margin = new Padding(0);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(1366, 36);
            pnlBarraTitulo.TabIndex = 0;
            pnlBarraTitulo.Paint += pnlBarraTitulo_Paint;
            pnlBarraTitulo.DoubleClick += pnlBarraTitulo_DoubleClick;
            pnlBarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // flpIdentidadeJanela
            // 
            flpIdentidadeJanela.AutoSize = true;
            flpIdentidadeJanela.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpIdentidadeJanela.Controls.Add(picLogoTitulo);
            flpIdentidadeJanela.Controls.Add(lblNomeJanela);
            flpIdentidadeJanela.Dock = DockStyle.Left;
            flpIdentidadeJanela.Location = new Point(0, 0);
            flpIdentidadeJanela.Margin = new Padding(0);
            flpIdentidadeJanela.Name = "flpIdentidadeJanela";
            flpIdentidadeJanela.Padding = new Padding(12, 0, 0, 0);
            flpIdentidadeJanela.Size = new Size(120, 36);
            flpIdentidadeJanela.TabIndex = 0;
            flpIdentidadeJanela.WrapContents = false;
            flpIdentidadeJanela.MouseDown += BarraTitulo_MouseDown;
            // 
            // picLogoTitulo
            // 
            picLogoTitulo.Image = (Image)resources.GetObject("picLogoTitulo.Image");
            picLogoTitulo.Location = new Point(12, 10);
            picLogoTitulo.Margin = new Padding(0, 10, 8, 10);
            picLogoTitulo.Name = "picLogoTitulo";
            picLogoTitulo.Size = new Size(32, 16);
            picLogoTitulo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoTitulo.TabIndex = 0;
            picLogoTitulo.TabStop = false;
            picLogoTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // lblNomeJanela
            // 
            lblNomeJanela.AutoSize = true;
            lblNomeJanela.Font = new Font("Segoe UI", 9F);
            lblNomeJanela.ForeColor = Color.FromArgb(48, 55, 65);
            lblNomeJanela.Location = new Point(52, 8);
            lblNomeJanela.Margin = new Padding(0, 8, 0, 0);
            lblNomeJanela.Name = "lblNomeJanela";
            lblNomeJanela.Size = new Size(68, 15);
            lblNomeJanela.TabIndex = 1;
            lblNomeJanela.Text = "KBJ Control";
            lblNomeJanela.MouseDown += BarraTitulo_MouseDown;
            // 
            // flpControlesJanela
            // 
            flpControlesJanela.Controls.Add(btnMinimizar);
            flpControlesJanela.Controls.Add(btnMaximizar);
            flpControlesJanela.Controls.Add(btnFechar);
            flpControlesJanela.Dock = DockStyle.Right;
            flpControlesJanela.Location = new Point(1228, 0);
            flpControlesJanela.Margin = new Padding(0);
            flpControlesJanela.Name = "flpControlesJanela";
            flpControlesJanela.Size = new Size(138, 36);
            flpControlesJanela.TabIndex = 1;
            flpControlesJanela.WrapContents = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.White;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 10F);
            btnMinimizar.ForeColor = Color.FromArgb(48, 55, 65);
            btnMinimizar.Location = new Point(0, 0);
            btnMinimizar.Margin = new Padding(0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 36);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Text = "—";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.White;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Font = new Font("Segoe UI", 10F);
            btnMaximizar.ForeColor = Color.FromArgb(48, 55, 65);
            btnMaximizar.Location = new Point(46, 0);
            btnMaximizar.Margin = new Padding(0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(46, 36);
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Text = "□";
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.White;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10F);
            btnFechar.ForeColor = Color.FromArgb(48, 55, 65);
            btnFechar.Location = new Point(92, 0);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 36);
            btnFechar.TabIndex = 2;
            btnFechar.TabStop = false;
            btnFechar.Text = "×";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            btnFechar.MouseEnter += btnFechar_MouseEnter;
            btnFechar.MouseLeave += btnFechar_MouseLeave;
            // 
            // tlpAreaBoasVindas
            // 
            tlpAreaBoasVindas.BackColor = Color.FromArgb(20, 34, 55);
            tlpAreaBoasVindas.ColumnCount = 2;
            tlpAreaBoasVindas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.9695549F));
            tlpAreaBoasVindas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.0304451F));
            tlpAreaBoasVindas.Controls.Add(tlpConteudoCentral, 1, 0);
            tlpAreaBoasVindas.Controls.Add(tlpImagemInicial, 0, 0);
            tlpAreaBoasVindas.Dock = DockStyle.Fill;
            tlpAreaBoasVindas.Location = new Point(0, 36);
            tlpAreaBoasVindas.Margin = new Padding(0);
            tlpAreaBoasVindas.Name = "tlpAreaBoasVindas";
            tlpAreaBoasVindas.RowCount = 1;
            tlpAreaBoasVindas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAreaBoasVindas.Size = new Size(1366, 704);
            tlpAreaBoasVindas.TabIndex = 1;
            // 
            // tlpConteudoCentral
            // 
            tlpConteudoCentral.Anchor = AnchorStyles.None;
            tlpConteudoCentral.ColumnCount = 1;
            tlpConteudoCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpConteudoCentral.Controls.Add(picLogo, 0, 0);
            tlpConteudoCentral.Controls.Add(flpNomeApp, 0, 1);
            tlpConteudoCentral.Controls.Add(lblInstrucao, 0, 4);
            tlpConteudoCentral.Controls.Add(btnIniciar, 0, 6);
            tlpConteudoCentral.Controls.Add(lblBoasVindas, 0, 3);
            tlpConteudoCentral.Location = new Point(711, 210);
            tlpConteudoCentral.Margin = new Padding(35, 0, 58, 0);
            tlpConteudoCentral.Name = "tlpConteudoCentral";
            tlpConteudoCentral.RowCount = 7;
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tlpConteudoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpConteudoCentral.Size = new Size(520, 284);
            tlpConteudoCentral.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(182, 0);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(156, 78);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // flpNomeApp
            // 
            flpNomeApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flpNomeApp.AutoSize = true;
            flpNomeApp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpNomeApp.Controls.Add(lblMarcaKbj);
            flpNomeApp.Controls.Add(lblMarcaControl);
            flpNomeApp.Location = new Point(167, 84);
            flpNomeApp.Margin = new Padding(0, 6, 0, 0);
            flpNomeApp.Name = "flpNomeApp";
            flpNomeApp.Size = new Size(185, 37);
            flpNomeApp.TabIndex = 1;
            flpNomeApp.WrapContents = false;
            // 
            // lblMarcaKbj
            // 
            lblMarcaKbj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMarcaKbj.AutoSize = true;
            lblMarcaKbj.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMarcaKbj.ForeColor = Color.White;
            lblMarcaKbj.Location = new Point(0, 0);
            lblMarcaKbj.Margin = new Padding(0, 0, 7, 0);
            lblMarcaKbj.Name = "lblMarcaKbj";
            lblMarcaKbj.Size = new Size(64, 37);
            lblMarcaKbj.TabIndex = 0;
            lblMarcaKbj.Text = "KBJ";
            lblMarcaKbj.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMarcaControl
            // 
            lblMarcaControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMarcaControl.AutoSize = true;
            lblMarcaControl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMarcaControl.ForeColor = Color.White;
            lblMarcaControl.Location = new Point(71, 0);
            lblMarcaControl.Margin = new Padding(0);
            lblMarcaControl.Name = "lblMarcaControl";
            lblMarcaControl.Size = new Size(114, 37);
            lblMarcaControl.TabIndex = 1;
            lblMarcaControl.Text = "Control";
            lblMarcaControl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInstrucao
            // 
            lblInstrucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblInstrucao.Font = new Font("Segoe UI", 10F);
            lblInstrucao.ForeColor = Color.FromArgb(180, 193, 210);
            lblInstrucao.Location = new Point(29, 170);
            lblInstrucao.Margin = new Padding(0);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(461, 63);
            lblInstrucao.TabIndex = 3;
            lblInstrucao.Text = "Organize entradas, acompanhe visitas e \r\nconsulte informações sempre que precisar.";
            lblInstrucao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnIniciar.BackColor = Color.FromArgb(232, 185, 63);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(209, 160, 37);
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 198, 83);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.FromArgb(48, 55, 65);
            btnIniciar.Location = new Point(158, 239);
            btnIniciar.Margin = new Padding(0);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(204, 45);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Começar agora";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblBoasVindas.ForeColor = Color.White;
            lblBoasVindas.Location = new Point(39, 128);
            lblBoasVindas.Margin = new Padding(0);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(442, 42);
            lblBoasVindas.TabIndex = 2;
            lblBoasVindas.Text = "Controle de acessos com agilidade e segurança";
            lblBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpImagemInicial
            // 
            tlpImagemInicial.ColumnCount = 1;
            tlpImagemInicial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpImagemInicial.Controls.Add(pictureBox1, 0, 0);
            tlpImagemInicial.Dock = DockStyle.Fill;
            tlpImagemInicial.Location = new Point(0, 0);
            tlpImagemInicial.Margin = new Padding(0);
            tlpImagemInicial.Name = "tlpImagemInicial";
            tlpImagemInicial.RowCount = 1;
            tlpImagemInicial.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpImagemInicial.Size = new Size(600, 704);
            tlpImagemInicial.TabIndex = 2;
            tlpImagemInicial.Paint += tlpImagemInicial_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 698);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlBarraStatus
            // 
            pnlBarraStatus.BackColor = Color.White;
            pnlBarraStatus.Controls.Add(lblStatusContexto);
            pnlBarraStatus.Controls.Add(lblStatusAmbiente);
            pnlBarraStatus.Dock = DockStyle.Fill;
            pnlBarraStatus.Location = new Point(0, 740);
            pnlBarraStatus.Margin = new Padding(0);
            pnlBarraStatus.Name = "pnlBarraStatus";
            pnlBarraStatus.Padding = new Padding(16, 0, 16, 0);
            pnlBarraStatus.Size = new Size(1366, 28);
            pnlBarraStatus.TabIndex = 2;
            pnlBarraStatus.Paint += pnlBarraStatus_Paint;
            // 
            // lblStatusContexto
            // 
            lblStatusContexto.AutoSize = true;
            lblStatusContexto.Dock = DockStyle.Left;
            lblStatusContexto.Font = new Font("Segoe UI", 8F);
            lblStatusContexto.ForeColor = Color.FromArgb(101, 112, 124);
            lblStatusContexto.Location = new Point(16, 0);
            lblStatusContexto.Name = "lblStatusContexto";
            lblStatusContexto.Padding = new Padding(0, 5, 0, 0);
            lblStatusContexto.Size = new Size(138, 18);
            lblStatusContexto.TabIndex = 0;
            lblStatusContexto.Text = "KBJ Control • Boas-vindas";
            // 
            // lblStatusAmbiente
            // 
            lblStatusAmbiente.AutoSize = true;
            lblStatusAmbiente.Dock = DockStyle.Right;
            lblStatusAmbiente.Font = new Font("Segoe UI", 8F);
            lblStatusAmbiente.ForeColor = Color.FromArgb(101, 112, 124);
            lblStatusAmbiente.Location = new Point(1350, 0);
            lblStatusAmbiente.Name = "lblStatusAmbiente";
            lblStatusAmbiente.Padding = new Padding(0, 5, 0, 0);
            lblStatusAmbiente.Size = new Size(0, 18);
            lblStatusAmbiente.TabIndex = 1;
            lblStatusAmbiente.Visible = false;
            // 
            // FrmBoasVindas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 34, 55);
            ClientSize = new Size(1366, 768);
            Controls.Add(tlpEstrutura);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MinimumSize = new Size(960, 600);
            Name = "FrmBoasVindas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control";
            WindowState = FormWindowState.Maximized;
            Load += FrmBoasVindas_Load;
            Resize += FrmBoasVindas_Resize;
            tlpEstrutura.ResumeLayout(false);
            pnlBarraTitulo.ResumeLayout(false);
            pnlBarraTitulo.PerformLayout();
            flpIdentidadeJanela.ResumeLayout(false);
            flpIdentidadeJanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoTitulo).EndInit();
            flpControlesJanela.ResumeLayout(false);
            tlpAreaBoasVindas.ResumeLayout(false);
            tlpConteudoCentral.ResumeLayout(false);
            tlpConteudoCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            flpNomeApp.ResumeLayout(false);
            flpNomeApp.PerformLayout();
            tlpImagemInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBarraStatus.ResumeLayout(false);
            pnlBarraStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstrutura;
        private Panel pnlBarraTitulo;
        private FlowLayoutPanel flpIdentidadeJanela;
        private PictureBox picLogoTitulo;
        private Label lblNomeJanela;
        private FlowLayoutPanel flpControlesJanela;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnFechar;
        private TableLayoutPanel tlpAreaBoasVindas;
        private TableLayoutPanel tlpConteudoCentral;
        private PictureBox picLogo;
        private FlowLayoutPanel flpNomeApp;
        private Label lblMarcaKbj;
        private Label lblMarcaControl;
        private Label lblBoasVindas;
        private Label lblInstrucao;
        private Button btnIniciar;
        private Panel pnlBarraStatus;
        private Label lblStatusContexto;
        private Label lblStatusAmbiente;
        private TableLayoutPanel tlpImagemInicial;
        private PictureBox pictureBox1;
    }
}
