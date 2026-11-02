namespace KBJK_Control.Telas.Principal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            tlpPrincipal = new TableLayoutPanel();
            pnlMenu = new Panel();
            tlpMenu = new TableLayoutPanel();
            tlpIdentidade = new TableLayoutPanel();
            picLogoMenu = new PictureBox();
            lblNomeAppMenu = new Label();
            tlpNavegacao = new TableLayoutPanel();
            btnHistorico = new Button();
            btnVisitantes = new Button();
            btnRecepcao = new Button();
            btnDashboard = new Button();
            tlpUsuario = new TableLayoutPanel();
            lblNomeUsuario = new Label();
            lblLoginUsuario = new Label();
            btnSair = new Button();
            pnlConteudo = new Panel();
            tlpPrincipal.SuspendLayout();
            pnlMenu.SuspendLayout();
            tlpMenu.SuspendLayout();
            tlpIdentidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoMenu).BeginInit();
            tlpNavegacao.SuspendLayout();
            tlpUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(pnlMenu, 0, 0);
            tlpPrincipal.Controls.Add(pnlConteudo, 1, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 1;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(1084, 661);
            tlpPrincipal.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(37, 45, 56);
            pnlMenu.Controls.Add(tlpMenu);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 661);
            pnlMenu.TabIndex = 0;
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = Color.Transparent;
            tlpMenu.ColumnCount = 1;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenu.Controls.Add(tlpIdentidade, 0, 0);
            tlpMenu.Controls.Add(tlpNavegacao, 0, 1);
            tlpMenu.Controls.Add(tlpUsuario, 0, 2);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(0, 0);
            tlpMenu.Margin = new Padding(0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 3;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tlpMenu.Size = new Size(200, 661);
            tlpMenu.TabIndex = 0;
            // 
            // tlpIdentidade
            // 
            tlpIdentidade.ColumnCount = 1;
            tlpIdentidade.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpIdentidade.Controls.Add(picLogoMenu, 0, 0);
            tlpIdentidade.Controls.Add(lblNomeAppMenu, 0, 1);
            tlpIdentidade.Dock = DockStyle.Fill;
            tlpIdentidade.Location = new Point(0, 0);
            tlpIdentidade.Margin = new Padding(0);
            tlpIdentidade.Name = "tlpIdentidade";
            tlpIdentidade.Padding = new Padding(0, 20, 0, 10);
            tlpIdentidade.RowCount = 2;
            tlpIdentidade.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIdentidade.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpIdentidade.Size = new Size(200, 140);
            tlpIdentidade.TabIndex = 0;
            // 
            // picLogoMenu
            // 
            picLogoMenu.Anchor = AnchorStyles.None;
            picLogoMenu.Image = (Image)resources.GetObject("picLogoMenu.Image");
            picLogoMenu.Location = new Point(48, 23);
            picLogoMenu.Name = "picLogoMenu";
            picLogoMenu.Size = new Size(104, 49);
            picLogoMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoMenu.TabIndex = 0;
            picLogoMenu.TabStop = false;
            // 
            // lblNomeAppMenu
            // 
            lblNomeAppMenu.Anchor = AnchorStyles.None;
            lblNomeAppMenu.AutoSize = true;
            lblNomeAppMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeAppMenu.ForeColor = Color.White;
            lblNomeAppMenu.Location = new Point(51, 92);
            lblNomeAppMenu.Name = "lblNomeAppMenu";
            lblNomeAppMenu.Size = new Size(98, 21);
            lblNomeAppMenu.TabIndex = 1;
            lblNomeAppMenu.Text = "KBJ Control";
            // 
            // tlpNavegacao
            // 
            tlpNavegacao.ColumnCount = 1;
            tlpNavegacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpNavegacao.Controls.Add(btnHistorico, 0, 3);
            tlpNavegacao.Controls.Add(btnVisitantes, 0, 2);
            tlpNavegacao.Controls.Add(btnRecepcao, 0, 1);
            tlpNavegacao.Controls.Add(btnDashboard, 0, 0);
            tlpNavegacao.Dock = DockStyle.Fill;
            tlpNavegacao.Location = new Point(0, 140);
            tlpNavegacao.Margin = new Padding(0);
            tlpNavegacao.Name = "tlpNavegacao";
            tlpNavegacao.RowCount = 5;
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpNavegacao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNavegacao.Size = new Size(200, 391);
            tlpNavegacao.TabIndex = 1;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(37, 45, 56);
            btnHistorico.Cursor = Cursors.Hand;
            btnHistorico.Dock = DockStyle.Fill;
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.ForeColor = Color.White;
            btnHistorico.Location = new Point(0, 144);
            btnHistorico.Margin = new Padding(0);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Padding = new Padding(20, 0, 0, 0);
            btnHistorico.Size = new Size(200, 48);
            btnHistorico.TabIndex = 3;
            btnHistorico.Text = "Histórico";
            btnHistorico.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnVisitantes
            // 
            btnVisitantes.BackColor = Color.FromArgb(37, 45, 56);
            btnVisitantes.Cursor = Cursors.Hand;
            btnVisitantes.Dock = DockStyle.Fill;
            btnVisitantes.FlatAppearance.BorderSize = 0;
            btnVisitantes.FlatStyle = FlatStyle.Flat;
            btnVisitantes.ForeColor = Color.White;
            btnVisitantes.Location = new Point(0, 96);
            btnVisitantes.Margin = new Padding(0);
            btnVisitantes.Name = "btnVisitantes";
            btnVisitantes.Padding = new Padding(20, 0, 0, 0);
            btnVisitantes.Size = new Size(200, 48);
            btnVisitantes.TabIndex = 2;
            btnVisitantes.Text = "Visitantes";
            btnVisitantes.TextAlign = ContentAlignment.MiddleLeft;
            btnVisitantes.UseVisualStyleBackColor = false;
            btnVisitantes.Click += btnVisitantes_Click;
            // 
            // btnRecepcao
            // 
            btnRecepcao.BackColor = Color.FromArgb(37, 45, 56);
            btnRecepcao.Cursor = Cursors.Hand;
            btnRecepcao.Dock = DockStyle.Fill;
            btnRecepcao.FlatAppearance.BorderSize = 0;
            btnRecepcao.FlatStyle = FlatStyle.Flat;
            btnRecepcao.ForeColor = Color.White;
            btnRecepcao.Location = new Point(0, 48);
            btnRecepcao.Margin = new Padding(0);
            btnRecepcao.Name = "btnRecepcao";
            btnRecepcao.Padding = new Padding(20, 0, 0, 0);
            btnRecepcao.Size = new Size(200, 48);
            btnRecepcao.TabIndex = 1;
            btnRecepcao.Text = "Recepção";
            btnRecepcao.TextAlign = ContentAlignment.MiddleLeft;
            btnRecepcao.UseVisualStyleBackColor = false;
            btnRecepcao.Click += btnRecepcao_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(212, 165, 30);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(200, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // tlpUsuario
            // 
            tlpUsuario.ColumnCount = 1;
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpUsuario.Controls.Add(lblNomeUsuario, 0, 0);
            tlpUsuario.Controls.Add(lblLoginUsuario, 0, 1);
            tlpUsuario.Controls.Add(btnSair, 0, 2);
            tlpUsuario.Dock = DockStyle.Fill;
            tlpUsuario.Location = new Point(0, 531);
            tlpUsuario.Margin = new Padding(0);
            tlpUsuario.Name = "tlpUsuario";
            tlpUsuario.Padding = new Padding(16, 12, 16, 12);
            tlpUsuario.RowCount = 3;
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUsuario.Size = new Size(200, 130);
            tlpUsuario.TabIndex = 2;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Anchor = AnchorStyles.Left;
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeUsuario.ForeColor = Color.White;
            lblNomeUsuario.Location = new Point(19, 17);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(81, 17);
            lblNomeUsuario.TabIndex = 0;
            lblNomeUsuario.Text = "Funcionário";
            // 
            // lblLoginUsuario
            // 
            lblLoginUsuario.Anchor = AnchorStyles.Left;
            lblLoginUsuario.AutoSize = true;
            lblLoginUsuario.Font = new Font("Segoe UI", 9F);
            lblLoginUsuario.ForeColor = Color.FromArgb(168, 178, 191);
            lblLoginUsuario.Location = new Point(19, 44);
            lblLoginUsuario.Name = "lblLoginUsuario";
            lblLoginUsuario.Size = new Size(47, 15);
            lblLoginUsuario.TabIndex = 1;
            lblLoginUsuario.Text = "Usuário";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(37, 45, 56);
            btnSair.Cursor = Cursors.Hand;
            btnSair.Dock = DockStyle.Fill;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(16, 64);
            btnSair.Margin = new Padding(0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(168, 54);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(224, 224, 224);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(200, 0);
            pnlConteudo.Margin = new Padding(0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(884, 661);
            pnlConteudo.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 700);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control";
            WindowState = FormWindowState.Maximized;
            tlpPrincipal.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            tlpMenu.ResumeLayout(false);
            tlpIdentidade.ResumeLayout(false);
            tlpIdentidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoMenu).EndInit();
            tlpNavegacao.ResumeLayout(false);
            tlpUsuario.ResumeLayout(false);
            tlpUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private Panel pnlMenu;
        private TableLayoutPanel tlpMenu;
        private TableLayoutPanel tlpIdentidade;
        private PictureBox picLogoMenu;
        private Label lblNomeAppMenu;
        private TableLayoutPanel tlpNavegacao;
        private Button btnHistorico;
        private Button btnVisitantes;
        private Button btnRecepcao;
        private Button btnDashboard;
        private TableLayoutPanel tlpUsuario;
        private Label lblNomeUsuario;
        private Label lblLoginUsuario;
        private Button btnSair;
        private Panel pnlConteudo;
    }
}