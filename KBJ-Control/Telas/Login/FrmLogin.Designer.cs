namespace KBJK_Control
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            tlpLogin = new TableLayoutPanel();
            tlpLogo = new TableLayoutPanel();
            lblLogo = new Label();
            picLogo = new PictureBox();
            pnlCentral = new KBJK_Control.Controles.TabelaArredondada();
            tlpCentral = new TableLayoutPanel();
            lblEsqueciSenha = new Label();
            pnlCampoSenha = new KBJK_Control.Controles.TabelaArredondada();
            txtSenha = new TextBox();
            lblSenha = new Label();
            pnlCampoUsuario = new KBJK_Control.Controles.TabelaArredondada();
            txtUser = new TextBox();
            lblUser = new Label();
            lblPreencha = new Label();
            pnlBotaoMostrarSenha = new KBJK_Control.Controles.TabelaArredondada();
            btnMostrarSenha = new Button();
            pnlBotaoEntrar = new KBJK_Control.Controles.TabelaArredondada();
            btnEntrar = new Button();
            lbl = new Label();
            tlpLogin.SuspendLayout();
            tlpLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlCentral.SuspendLayout();
            tlpCentral.SuspendLayout();
            pnlCampoSenha.SuspendLayout();
            pnlCampoUsuario.SuspendLayout();
            pnlBotaoMostrarSenha.SuspendLayout();
            pnlBotaoEntrar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpLogin
            // 
            tlpLogin.BackColor = Color.FromArgb(20, 34, 55);
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.Controls.Add(tlpLogo, 1, 1);
            tlpLogin.Controls.Add(pnlCentral, 1, 3);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(0, 0);
            tlpLogin.Margin = new Padding(0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 5;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 525F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpLogin.Size = new Size(1142, 750);
            tlpLogin.TabIndex = 0;
            // 
            // tlpLogo
            // 
            tlpLogo.BackColor = Color.Transparent;
            tlpLogo.ColumnCount = 2;
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogo.Controls.Add(lblLogo, 1, 0);
            tlpLogo.Controls.Add(picLogo, 0, 0);
            tlpLogo.Dock = DockStyle.Fill;
            tlpLogo.Location = new Point(271, 70);
            tlpLogo.Margin = new Padding(0);
            tlpLogo.Name = "tlpLogo";
            tlpLogo.Padding = new Padding(155, 0, 0, 0);
            tlpLogo.RowCount = 1;
            tlpLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLogo.Size = new Size(600, 60);
            tlpLogo.TabIndex = 1;
            tlpLogo.Paint += tableLayoutPanel1_Paint;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.Left;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(244, 11);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(160, 37);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "KBJ Control";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(160, 11);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(75, 38);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlCentral
            // 
            pnlCentral.Anchor = AnchorStyles.None;
            pnlCentral.BackColor = Color.White;
            pnlCentral.Controls.Add(tlpCentral);
            pnlCentral.Location = new Point(271, 155);
            pnlCentral.Margin = new Padding(0);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Padding = new Padding(1);
            pnlCentral.Size = new Size(600, 525);
            pnlCentral.TabIndex = 2;
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 2;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.Controls.Add(lblEsqueciSenha, 1, 7);
            tlpCentral.Controls.Add(pnlCampoSenha, 0, 5);
            tlpCentral.Controls.Add(lblSenha, 0, 4);
            tlpCentral.Controls.Add(pnlCampoUsuario, 0, 3);
            tlpCentral.Controls.Add(lblUser, 0, 2);
            tlpCentral.Controls.Add(lblPreencha, 0, 1);
            tlpCentral.Controls.Add(pnlBotaoMostrarSenha, 0, 7);
            tlpCentral.Controls.Add(pnlBotaoEntrar, 0, 8);
            tlpCentral.Controls.Add(lbl, 0, 9);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(1, 1);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.Padding = new Padding(40, 32, 40, 30);
            tlpCentral.RowCount = 10;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.Size = new Size(598, 523);
            tlpCentral.TabIndex = 1;
            tlpCentral.Paint += tlpCentral_Paint_1;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.Anchor = AnchorStyles.Right;
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Cursor = Cursors.Hand;
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEsqueciSenha.ForeColor = Color.FromArgb(133, 96, 11);
            lblEsqueciSenha.Location = new Point(412, 300);
            lblEsqueciSenha.Margin = new Padding(0);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(146, 20);
            lblEsqueciSenha.TabIndex = 5;
            lblEsqueciSenha.Text = "Esqueci minha senha";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // pnlCampoSenha
            // 
            pnlCampoSenha.BackColor = Color.White;
            tlpCentral.SetColumnSpan(pnlCampoSenha, 2);
            pnlCampoSenha.Controls.Add(txtSenha);
            pnlCampoSenha.Dock = DockStyle.Fill;
            pnlCampoSenha.Location = new Point(40, 220);
            pnlCampoSenha.Margin = new Padding(0, 6, 0, 6);
            pnlCampoSenha.Name = "pnlCampoSenha";
            pnlCampoSenha.Padding = new Padding(1);
            pnlCampoSenha.Size = new Size(518, 32);
            pnlCampoSenha.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(12, 3);
            txtSenha.Margin = new Padding(0);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = " Informe sua senha.";
            txtSenha.Size = new Size(516, 23);
            txtSenha.TabIndex = 0;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Left;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.FromArgb(20, 34, 55);
            lblSenha.Location = new Point(40, 181);
            lblSenha.Margin = new Padding(0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // pnlCampoUsuario
            // 
            pnlCampoUsuario.BackColor = Color.Transparent;
            tlpCentral.SetColumnSpan(pnlCampoUsuario, 2);
            pnlCampoUsuario.Controls.Add(txtUser);
            pnlCampoUsuario.Dock = DockStyle.Fill;
            pnlCampoUsuario.Location = new Point(40, 135);
            pnlCampoUsuario.Margin = new Padding(0, 6, 0, 6);
            pnlCampoUsuario.Name = "pnlCampoUsuario";
            pnlCampoUsuario.Padding = new Padding(1);
            pnlCampoUsuario.Size = new Size(518, 31);
            pnlCampoUsuario.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.Location = new Point(12, 3);
            txtUser.Margin = new Padding(0);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Informe seu usuário.";
            txtUser.Size = new Size(516, 23);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.Enter += txtUser_Enter;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(20, 34, 55);
            lblUser.Location = new Point(40, 99);
            lblUser.Margin = new Padding(0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(142, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Nome de usuário";
            lblUser.Click += lblUser_Click;
            // 
            // lblPreencha
            // 
            lblPreencha.Anchor = AnchorStyles.Left;
            lblPreencha.AutoSize = true;
            tlpCentral.SetColumnSpan(lblPreencha, 2);
            lblPreencha.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreencha.ForeColor = Color.FromArgb(20, 34, 55);
            lblPreencha.Location = new Point(40, 44);
            lblPreencha.Margin = new Padding(0);
            lblPreencha.Name = "lblPreencha";
            lblPreencha.Size = new Size(325, 35);
            lblPreencha.TabIndex = 0;
            lblPreencha.Text = "Preencha suas informações";
            lblPreencha.Click += lblPreencha_Click;
            // 
            // pnlBotaoMostrarSenha
            // 
            pnlBotaoMostrarSenha.BackColor = Color.White;
            pnlBotaoMostrarSenha.Controls.Add(btnMostrarSenha);
            pnlBotaoMostrarSenha.Dock = DockStyle.Fill;
            pnlBotaoMostrarSenha.Location = new Point(40, 284);
            pnlBotaoMostrarSenha.Margin = new Padding(0);
            pnlBotaoMostrarSenha.Name = "pnlBotaoMostrarSenha";
            pnlBotaoMostrarSenha.Padding = new Padding(1);
            pnlBotaoMostrarSenha.Size = new Size(259, 52);
            pnlBotaoMostrarSenha.TabIndex = 5;
            // 
            // btnMostrarSenha
            // 
            btnMostrarSenha.BackColor = Color.White;
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.Dock = DockStyle.Fill;
            btnMostrarSenha.FlatAppearance.BorderColor = Color.FromArgb(218, 225, 233);
            btnMostrarSenha.FlatStyle = FlatStyle.Flat;
            btnMostrarSenha.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarSenha.ForeColor = Color.FromArgb(52, 67, 88);
            btnMostrarSenha.Location = new Point(1, 1);
            btnMostrarSenha.Margin = new Padding(0);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(257, 50);
            btnMostrarSenha.TabIndex = 0;
            btnMostrarSenha.Text = "Mostrar senha";
            btnMostrarSenha.UseVisualStyleBackColor = false;
            btnMostrarSenha.Click += btnMostrarSenha_Click;
            // 
            // pnlBotaoEntrar
            // 
            pnlBotaoEntrar.BackColor = Color.White;
            tlpCentral.SetColumnSpan(pnlBotaoEntrar, 2);
            pnlBotaoEntrar.Controls.Add(btnEntrar);
            pnlBotaoEntrar.Dock = DockStyle.Fill;
            pnlBotaoEntrar.ForeColor = Color.Transparent;
            pnlBotaoEntrar.Location = new Point(40, 341);
            pnlBotaoEntrar.Margin = new Padding(0, 5, 0, 5);
            pnlBotaoEntrar.Name = "pnlBotaoEntrar";
            pnlBotaoEntrar.Padding = new Padding(1);
            pnlBotaoEntrar.Size = new Size(518, 58);
            pnlBotaoEntrar.TabIndex = 6;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(232, 185, 63);
            btnEntrar.BackgroundImageLayout = ImageLayout.None;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Dock = DockStyle.Fill;
            btnEntrar.FlatAppearance.BorderColor = SystemColors.Window;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(1, 1);
            btnEntrar.Margin = new Padding(0);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(516, 56);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            tlpCentral.SetColumnSpan(lbl, 2);
            lbl.ForeColor = Color.FromArgb(100, 113, 129);
            lbl.Location = new Point(96, 438);
            lbl.Margin = new Padding(0);
            lbl.Name = "lbl";
            lbl.Size = new Size(406, 20);
            lbl.TabIndex = 7;
            lbl.Text = "Acesso exclusivo de funcionários cadastrados pela empresa.";
            lbl.Click += label1_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 34, 55);
            ClientSize = new Size(1142, 750);
            Controls.Add(tlpLogin);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(796, 763);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control - Login";
            WindowState = FormWindowState.Maximized;
            tlpLogin.ResumeLayout(false);
            tlpLogo.ResumeLayout(false);
            tlpLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlCentral.ResumeLayout(false);
            tlpCentral.ResumeLayout(false);
            tlpCentral.PerformLayout();
            pnlCampoSenha.ResumeLayout(false);
            pnlCampoSenha.PerformLayout();
            pnlCampoUsuario.ResumeLayout(false);
            pnlCampoUsuario.PerformLayout();
            pnlBotaoMostrarSenha.ResumeLayout(false);
            pnlBotaoEntrar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLogin;
        private TableLayoutPanel tlpLogo;
        private PictureBox picLogo;
        private Label lblLogo;
        private KBJK_Control.Controles.TabelaArredondada pnlCentral;
        private TableLayoutPanel tlpCentral;
        private Label lblPreencha;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnMostrarSenha;
        private Label lblEsqueciSenha;
        private Label lbl;
        private KBJK_Control.Controles.TabelaArredondada pnlCampoUsuario;
        private KBJK_Control.Controles.TabelaArredondada pnlCampoSenha;
        private KBJK_Control.Controles.TabelaArredondada pnlBotaoMostrarSenha;
        private KBJK_Control.Controles.TabelaArredondada pnlBotaoEntrar;
    }
}
