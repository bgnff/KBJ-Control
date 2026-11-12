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
            pnlCentral = new AntdUI.Panel();
            tlpCentral = new TableLayoutPanel();
            lblEsqueciSenha = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            lblPreencha = new Label();
            btnMostrarSenha = new Button();
            btnEntrar = new Button();
            lbl = new Label();
            tlpLogin.SuspendLayout();
            tlpLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlCentral.SuspendLayout();
            tlpCentral.SuspendLayout();
            SuspendLayout();
            //
            // tlpLogin
            //
            tlpLogin.BackColor = Color.FromArgb(20, 34, 55);
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 420F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpLogin.Controls.Add(tlpLogo, 1, 0);
            tlpLogin.Controls.Add(pnlCentral, 1, 1);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(0, 0);
            tlpLogin.Margin = new Padding(0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 3;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 360F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tlpLogin.Size = new Size(914, 600);
            tlpLogin.TabIndex = 0;
            // 
            // tlpLogo
            // 
            tlpLogo.BackColor = Color.Transparent;
            tlpLogo.ColumnCount = 2;
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogo.Controls.Add(lblLogo, 1, 0);
            tlpLogo.Controls.Add(picLogo, 0, 0);
            tlpLogo.Dock = DockStyle.Fill;
            tlpLogo.Location = new Point(247, 0);
            tlpLogo.Margin = new Padding(0);
            tlpLogo.Name = "tlpLogo";
            tlpLogo.Padding = new Padding(108, 0, 0, 0);
            tlpLogo.RowCount = 1;
            tlpLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLogo.Size = new Size(420, 62);
            tlpLogo.TabIndex = 1;
            tlpLogo.Paint += tableLayoutPanel1_Paint;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.Left;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(157, 12);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(160, 37);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "KBJ Control";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(112, 12);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(38, 38);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlCentral
            // 
            pnlCentral.Anchor = AnchorStyles.None;
            pnlCentral.BackColor = Color.White;
            pnlCentral.BorderColor = Color.FromArgb(232, 185, 63);
            pnlCentral.BorderWidth = 1F;
            pnlCentral.Controls.Add(tlpCentral);
            pnlCentral.Location = new Point(247, 62);
            pnlCentral.Margin = new Padding(0);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(420, 360);
            pnlCentral.TabIndex = 2;
            pnlCentral.Text = "panel1";
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 2;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.Controls.Add(lblEsqueciSenha, 1, 7);
            tlpCentral.Controls.Add(txtSenha, 0, 5);
            tlpCentral.Controls.Add(lblSenha, 0, 4);
            tlpCentral.Controls.Add(txtUser, 0, 3);
            tlpCentral.Controls.Add(lblUser, 0, 2);
            tlpCentral.Controls.Add(lblPreencha, 0, 1);
            tlpCentral.Controls.Add(btnMostrarSenha, 0, 7);
            tlpCentral.Controls.Add(btnEntrar, 0, 8);
            tlpCentral.Controls.Add(lbl, 0, 9);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(2, 2);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.Padding = new Padding(22, 18, 22, 16);
            tlpCentral.RowCount = 10;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpCentral.Size = new Size(416, 356);
            tlpCentral.TabIndex = 1;
            tlpCentral.Paint += tlpCentral_Paint_1;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.Anchor = AnchorStyles.Right;
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEsqueciSenha.ForeColor = Color.FromArgb(186, 132, 12);
            lblEsqueciSenha.Location = new Point(248, 209);
            lblEsqueciSenha.Margin = new Padding(0);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(146, 20);
            lblEsqueciSenha.TabIndex = 5;
            lblEsqueciSenha.Text = "Esqueci minha senha";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpCentral.SetColumnSpan(txtSenha, 2);
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(22, 163);
            txtSenha.Margin = new Padding(0, 5, 0, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = " Informe sua senha.";
            txtSenha.Size = new Size(372, 30);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Left;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.FromArgb(20, 34, 55);
            lblSenha.Location = new Point(22, 131);
            lblSenha.Margin = new Padding(0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpCentral.SetColumnSpan(txtUser, 2);
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.Location = new Point(22, 95);
            txtUser.Margin = new Padding(0, 5, 0, 5);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Informe seu usuário.";
            txtUser.Size = new Size(372, 30);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.Enter += txtUser_Enter;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(20, 34, 55);
            lblUser.Location = new Point(22, 63);
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
            lblPreencha.Location = new Point(22, 24);
            lblPreencha.Margin = new Padding(0);
            lblPreencha.Name = "lblPreencha";
            lblPreencha.Size = new Size(325, 35);
            lblPreencha.TabIndex = 0;
            lblPreencha.Text = "Preencha suas informações";
            lblPreencha.Click += lblPreencha_Click;
            // 
            // btnMostrarSenha
            //
            btnMostrarSenha.Anchor = AnchorStyles.Left;
            btnMostrarSenha.BackColor = Color.White;
            btnMostrarSenha.Cursor = Cursors.Hand;
            btnMostrarSenha.FlatAppearance.BorderColor = Color.FromArgb(218, 225, 233);
            btnMostrarSenha.FlatStyle = FlatStyle.Flat;
            btnMostrarSenha.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarSenha.ForeColor = Color.FromArgb(52, 67, 88);
            btnMostrarSenha.Location = new Point(22, 205);
            btnMostrarSenha.Margin = new Padding(0);
            btnMostrarSenha.Name = "btnMostrarSenha";
            btnMostrarSenha.Size = new Size(104, 27);
            btnMostrarSenha.TabIndex = 5;
            btnMostrarSenha.Text = "Mostrar senha";
            btnMostrarSenha.UseVisualStyleBackColor = false;
            btnMostrarSenha.Click += btnMostrarSenha_Click;
            //
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEntrar.BackColor = Color.FromArgb(232, 185, 63);
            btnEntrar.BackgroundImageLayout = ImageLayout.None;
            tlpCentral.SetColumnSpan(btnEntrar, 2);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(22, 240);
            btnEntrar.Margin = new Padding(0, 4, 0, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(372, 34);
            btnEntrar.TabIndex = 6;
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
            lbl.Location = new Point(35, 289);
            lbl.Margin = new Padding(0);
            lbl.Name = "lbl";
            lbl.Size = new Size(346, 40);
            lbl.TabIndex = 7;
            lbl.Text = "Acesso exclusivo de funcionários cadastrados pela empresa.";
            lbl.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 34, 55);
            ClientSize = new Size(914, 600);
            Controls.Add(tlpLogin);
            Margin = new Padding(3, 4, 3, 4);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpLogin;
        private TableLayoutPanel tlpLogo;
        private PictureBox picLogo;
        private Label lblLogo;
        private AntdUI.Panel pnlCentral;
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
    }
}
