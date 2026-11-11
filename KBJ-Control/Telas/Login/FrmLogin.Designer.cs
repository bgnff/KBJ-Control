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
            tlpLogin.Anchor = AnchorStyles.None;
            tlpLogin.ColumnCount = 3;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.1463432F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.85366F));
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            tlpLogin.Controls.Add(tlpLogo, 1, 0);
            tlpLogin.Controls.Add(pnlCentral, 1, 1);
            tlpLogin.Location = new Point(0, 0);
            tlpLogin.Margin = new Padding(0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 3;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 25.454546F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 74.5454559F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpLogin.Size = new Size(914, 600);
            tlpLogin.TabIndex = 0;
            // 
            // tlpLogo
            // 
            tlpLogo.ColumnCount = 3;
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tlpLogo.Controls.Add(lblLogo, 2, 1);
            tlpLogo.Controls.Add(picLogo, 1, 1);
            tlpLogo.Dock = DockStyle.Fill;
            tlpLogo.Location = new Point(239, 4);
            tlpLogo.Margin = new Padding(3, 4, 3, 4);
            tlpLogo.Name = "tlpLogo";
            tlpLogo.RowCount = 2;
            tlpLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 7.54716969F));
            tlpLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 92.45283F));
            tlpLogo.Size = new Size(449, 123);
            tlpLogo.TabIndex = 1;
            tlpLogo.Paint += tableLayoutPanel1_Paint;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.Left;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(181, 37);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(258, 57);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "KBJ Control";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(58, 9);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(114, 114);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlCentral
            // 
            pnlCentral.BorderColor = Color.Gray;
            pnlCentral.BorderWidth = 1F;
            pnlCentral.Controls.Add(tlpCentral);
            pnlCentral.Dock = DockStyle.Fill;
            pnlCentral.Location = new Point(239, 135);
            pnlCentral.Margin = new Padding(3, 4, 3, 4);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(449, 375);
            pnlCentral.TabIndex = 2;
            pnlCentral.Text = "panel1";
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 3;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.107527F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.89247F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tlpCentral.Controls.Add(lblEsqueciSenha, 1, 7);
            tlpCentral.Controls.Add(txtSenha, 1, 5);
            tlpCentral.Controls.Add(lblSenha, 1, 4);
            tlpCentral.Controls.Add(txtUser, 1, 3);
            tlpCentral.Controls.Add(lblUser, 1, 2);
            tlpCentral.Controls.Add(lblPreencha, 1, 1);
            tlpCentral.Controls.Add(btnEntrar, 1, 6);
            tlpCentral.Controls.Add(lbl, 1, 8);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(2, 2);
            tlpCentral.Margin = new Padding(3, 4, 3, 4);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 9;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 16.27907F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 83.72093F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpCentral.Size = new Size(445, 371);
            tlpCentral.TabIndex = 1;
            tlpCentral.Paint += tlpCentral_Paint_1;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEsqueciSenha.ForeColor = Color.FromArgb(212, 165, 30);
            lblEsqueciSenha.Location = new Point(24, 303);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(146, 20);
            lblEsqueciSenha.TabIndex = 5;
            lblEsqueciSenha.Text = "Esqueci minha senha";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(24, 204);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = " Informe sua senha.";
            txtSenha.Size = new Size(393, 27);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(24, 172);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(24, 124);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Informe seu usuário.";
            txtUser.Size = new Size(393, 27);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.Enter += txtUser_Enter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUser.Location = new Point(24, 88);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(142, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Nome de usuário";
            lblUser.Click += lblUser_Click;
            // 
            // lblPreencha
            // 
            lblPreencha.AutoSize = true;
            lblPreencha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreencha.Location = new Point(24, 22);
            lblPreencha.Margin = new Padding(3, 8, 3, 0);
            lblPreencha.Name = "lblPreencha";
            lblPreencha.Size = new Size(260, 28);
            lblPreencha.TabIndex = 0;
            lblPreencha.Text = "Preencha suas informações";
            lblPreencha.Click += lblPreencha_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(212, 165, 30);
            btnEntrar.BackgroundImageLayout = ImageLayout.None;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(24, 259);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(82, 33);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            lbl.ForeColor = SystemColors.ActiveBorder;
            lbl.Location = new Point(47, 346);
            lbl.Name = "lbl";
            lbl.Size = new Size(346, 25);
            lbl.TabIndex = 7;
            lbl.Text = "Acesso exclusivo de funcionários cadastrados pela empresa.";
            lbl.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Label lblEsqueciSenha;
        private Label lbl;
    }
}
