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
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEstrutura.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEstrutura.Size = new Size(984, 611);
            tlpEstrutura.TabIndex = 0;
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.White;
            pnlCabecalho.Dock = DockStyle.Fill;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(984, 36);
            pnlCabecalho.TabIndex = 0;
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.FromArgb(244, 245, 247);
            tlpCentral.ColumnCount = 3;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 520F));
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCentral.Controls.Add(tlpBoasVindas, 1, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 36);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 3;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 295F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCentral.Size = new Size(984, 575);
            tlpCentral.TabIndex = 1;
            // 
            // tlpBoasVindas
            // 
            tlpBoasVindas.ColumnCount = 1;
            tlpBoasVindas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBoasVindas.Controls.Add(picLogo, 0, 0);
            tlpBoasVindas.Controls.Add(lblNomeApp, 0, 1);
            tlpBoasVindas.Controls.Add(lblBoasVindas, 0, 2);
            tlpBoasVindas.Controls.Add(lblIntrucao, 0, 3);
            tlpBoasVindas.Controls.Add(btnIniciar, 0, 4);
            tlpBoasVindas.Dock = DockStyle.Fill;
            tlpBoasVindas.Location = new Point(232, 140);
            tlpBoasVindas.Margin = new Padding(0);
            tlpBoasVindas.Name = "tlpBoasVindas";
            tlpBoasVindas.RowCount = 5;
            tlpBoasVindas.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpBoasVindas.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpBoasVindas.RowStyles.Add(new RowStyle());
            tlpBoasVindas.RowStyles.Add(new RowStyle());
            tlpBoasVindas.RowStyles.Add(new RowStyle());
            tlpBoasVindas.Size = new Size(520, 295);
            tlpBoasVindas.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.None;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(182, 6);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(156, 78);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNomeApp
            // 
            lblNomeApp.Anchor = AnchorStyles.None;
            lblNomeApp.AutoSize = true;
            lblNomeApp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeApp.Location = new Point(176, 91);
            lblNomeApp.Name = "lblNomeApp";
            lblNomeApp.Size = new Size(168, 37);
            lblNomeApp.TabIndex = 1;
            lblNomeApp.Text = "KBJ Control";
            lblNomeApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Anchor = AnchorStyles.None;
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI Semibold", 13.25F, FontStyle.Bold);
            lblBoasVindas.Location = new Point(142, 142);
            lblBoasVindas.Margin = new Padding(3, 12, 3, 0);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(235, 25);
            lblBoasVindas.TabIndex = 2;
            lblBoasVindas.Text = "Bem-vindo ao KBJ Control!";
            // 
            // lblIntrucao
            // 
            lblIntrucao.Anchor = AnchorStyles.None;
            lblIntrucao.AutoSize = true;
            lblIntrucao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIntrucao.Location = new Point(133, 187);
            lblIntrucao.Margin = new Padding(3, 20, 3, 0);
            lblIntrucao.Name = "lblIntrucao";
            lblIntrucao.Size = new Size(253, 17);
            lblIntrucao.TabIndex = 3;
            lblIntrucao.Text = "Controle seus acessos, da entrada à saída.";
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top;
            btnIniciar.BackColor = Color.FromArgb(212, 165, 30);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(170, 220);
            btnIniciar.Margin = new Padding(3, 16, 3, 3);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(180, 44);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // FrmBoasVindas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(tlpEstrutura);
            Name = "FrmBoasVindas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control";
            WindowState = FormWindowState.Maximized;
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