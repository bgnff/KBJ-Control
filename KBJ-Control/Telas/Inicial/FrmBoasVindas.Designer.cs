namespace KBJK_Control.Telas.Inicial
{
    partial class FrmBoasVindas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoasVindas));
            tlpEstrutura = new TableLayoutPanel();
            pnlCabecalho = new Panel();
            tlpCentral = new TableLayoutPanel();
            tlpBoasVindas = new TableLayoutPanel();
            picLogo = new PictureBox();
            lblNomeApp = new Label();
            lblBoasVindas = new Label();
            lblIntrucao = new Label();
            btnIniciar = new Button();
            tlpEstrutura.SuspendLayout();
            tlpCentral.SuspendLayout();
            tlpBoasVindas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // tlpEstrutura
            // 
            tlpEstrutura.ColumnCount = 1;
            tlpEstrutura.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEstrutura.Controls.Add(pnlCabecalho, 0, 0);
            tlpEstrutura.Controls.Add(tlpCentral, 0, 1);
            tlpEstrutura.Dock = DockStyle.Fill;
            tlpEstrutura.Location = new Point(0, 0);
            tlpEstrutura.Margin = new Padding(0);
            tlpEstrutura.Name = "tlpEstrutura";
            tlpEstrutura.RowCount = 2;
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tlpEstrutura.Size = new Size(1125, 815);
            tlpEstrutura.TabIndex = 0;
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.White;
            pnlCabecalho.Dock = DockStyle.Fill;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1125, 48);
            pnlCabecalho.TabIndex = 0;
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.FromArgb(244, 245, 247);
            tlpCentral.ColumnCount = 3;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 594F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.Controls.Add(tlpBoasVindas, 1, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 48);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 3;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 393F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.Size = new Size(1125, 767);
            tlpCentral.TabIndex = 1;
            // 
            // tlpBoasVindas
            // 
            tlpBoasVindas.ColumnCount = 1;
            tlpBoasVindas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBoasVindas.Controls.Add(picLogo, 0, 0);
            tlpBoasVindas.Controls.Add(lblNomeApp, 0, 1);
            tlpBoasVindas.Controls.Add(btnIniciar, 0, 4);
            tlpBoasVindas.Controls.Add(lblIntrucao, 0, 3);
            tlpBoasVindas.Controls.Add(lblBoasVindas, 0, 2);
            tlpBoasVindas.Dock = DockStyle.Fill;
            tlpBoasVindas.Location = new Point(265, 187);
            tlpBoasVindas.Margin = new Padding(0);
            tlpBoasVindas.Name = "tlpBoasVindas";
            tlpBoasVindas.RowCount = 5;
            tlpBoasVindas.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpBoasVindas.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpBoasVindas.RowStyles.Add(new RowStyle());
            tlpBoasVindas.RowStyles.Add(new RowStyle());
            tlpBoasVindas.RowStyles.Add(new RowStyle());
            tlpBoasVindas.Size = new Size(594, 393);
            tlpBoasVindas.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(208, 8);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(178, 104);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNomeApp
            // 
            lblNomeApp.Anchor = AnchorStyles.None;
            lblNomeApp.AutoSize = true;
            lblNomeApp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeApp.Location = new Point(192, 123);
            lblNomeApp.Name = "lblNomeApp";
            lblNomeApp.Size = new Size(209, 46);
            lblNomeApp.TabIndex = 1;
            lblNomeApp.Text = "KBJ Control";
            lblNomeApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Anchor = AnchorStyles.None;
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI Semibold", 13.25F, FontStyle.Bold);
            lblBoasVindas.Location = new Point(150, 189);
            lblBoasVindas.Margin = new Padding(3, 16, 3, 0);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(294, 31);
            lblBoasVindas.TabIndex = 2;
            lblBoasVindas.Text = "Bem-vindo ao KBJ Control!";
            // 
            // lblIntrucao
            // 
            lblIntrucao.Anchor = AnchorStyles.None;
            lblIntrucao.AutoSize = true;
            lblIntrucao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIntrucao.Location = new Point(129, 247);
            lblIntrucao.Margin = new Padding(3, 27, 3, 0);
            lblIntrucao.Name = "lblIntrucao";
            lblIntrucao.Size = new Size(336, 23);
            lblIntrucao.TabIndex = 3;
            lblIntrucao.Text = "Controle seus acessos, da entrada à saída.";
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.BackColor = Color.FromArgb(212, 165, 30);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.Black;
            btnIniciar.Location = new Point(210, 318);
            btnIniciar.Margin = new Padding(3, 21, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(174, 44);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // FrmBoasVindas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 815);
            Controls.Add(tlpEstrutura);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBoasVindas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control";
            WindowState = FormWindowState.Maximized;
            Load += FrmBoasVindas_Load;
            tlpEstrutura.ResumeLayout(false);
            tlpCentral.ResumeLayout(false);
            tlpBoasVindas.ResumeLayout(false);
            tlpBoasVindas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpEstrutura;
        private Panel pnlCabecalho;
        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tlpBoasVindas;
        private PictureBox picLogo;
        private Label lblNomeApp;
        private Label lblBoasVindas;
        private Label lblIntrucao;
        private Button btnIniciar;
    }
}