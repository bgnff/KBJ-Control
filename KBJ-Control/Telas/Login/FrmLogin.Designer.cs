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
            tlpPrincipal = new TableLayoutPanel();
            tlpLogo = new TableLayoutPanel();
            lblLogo = new Label();
            picLogo = new PictureBox();
            panel1 = new AntdUI.Panel();
            tlpCentral = new TableLayoutPanel();
            lblPreencha = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblEsqueciSenha = new Label();
            btnEntrar = new Button();
            tlpPrincipal.SuspendLayout();
            tlpLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            tlpCentral.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.Anchor = AnchorStyles.None;
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.1463432F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.85366F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tlpPrincipal.Controls.Add(tlpLogo, 1, 0);
            tlpPrincipal.Controls.Add(panel1, 1, 1);
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5310726F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 71.4689255F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpPrincipal.Size = new Size(800, 450);
            tlpPrincipal.TabIndex = 0;
            // 
            // tlpLogo
            // 
            tlpLogo.ColumnCount = 2;
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.54054F));
            tlpLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.45946F));
            tlpLogo.Controls.Add(lblLogo, 1, 1);
            tlpLogo.Controls.Add(picLogo, 0, 1);
            tlpLogo.Dock = DockStyle.Fill;
            tlpLogo.Location = new Point(197, 3);
            tlpLogo.Name = "tlpLogo";
            tlpLogo.RowCount = 2;
            tlpLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tlpLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tlpLogo.Size = new Size(370, 104);
            tlpLogo.TabIndex = 1;
            tlpLogo.Paint += tableLayoutPanel1_Paint;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.None;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(140, 49);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(202, 45);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "KBJ Control";
            lblLogo.Click += label1_Click_1;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(6, 40);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 64);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tlpCentral);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(197, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 269);
            panel1.TabIndex = 2;
            panel1.Text = "panel1";
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.Controls.Add(lblPreencha, 0, 0);
            tlpCentral.Controls.Add(lblUser, 0, 1);
            tlpCentral.Controls.Add(txtUser, 0, 2);
            tlpCentral.Controls.Add(lblSenha, 0, 3);
            tlpCentral.Controls.Add(txtSenha, 0, 4);
            tlpCentral.Controls.Add(lblEsqueciSenha, 0, 6);
            tlpCentral.Controls.Add(btnEntrar, 0, 5);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 9;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 67.79661F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 32.20339F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.Size = new Size(370, 269);
            tlpCentral.TabIndex = 1;
            // 
            // lblPreencha
            // 
            lblPreencha.AutoSize = true;
            lblPreencha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreencha.Location = new Point(3, 0);
            lblPreencha.Name = "lblPreencha";
            lblPreencha.Size = new Size(207, 21);
            lblPreencha.TabIndex = 0;
            lblPreencha.Text = "Preencha suas informações";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUser.Location = new Point(3, 40);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(116, 19);
            lblUser.TabIndex = 1;
            lblUser.Text = "Nome de usuário";
            // 
            // txtUser
            // 
            txtUser.Dock = DockStyle.Fill;
            txtUser.Location = new Point(3, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(364, 23);
            txtUser.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(3, 107);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 17);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Location = new Point(3, 130);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(364, 23);
            txtSenha.TabIndex = 4;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Location = new Point(3, 208);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(118, 15);
            lblEsqueciSenha.TabIndex = 5;
            lblEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(3, 174);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpPrincipal);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control - Login";
            WindowState = FormWindowState.Maximized;
            tlpPrincipal.ResumeLayout(false);
            tlpLogo.ResumeLayout(false);
            tlpLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            tlpCentral.ResumeLayout(false);
            tlpCentral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpLogo;
        private PictureBox picLogo;
        private Label lblLogo;
        private AntdUI.Panel panel1;
        private TableLayoutPanel tlpCentral;
        private Label lblPreencha;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblEsqueciSenha;
        private Button btnEntrar;
    }
}
