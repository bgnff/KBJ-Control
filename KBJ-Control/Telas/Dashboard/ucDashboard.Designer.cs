namespace KBJK_Control.Telas.Dashboard
{
    partial class ucDashboard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tlpDashboard = new TableLayoutPanel();
            pnlCabecalhoDashboard = new Panel();
            lblTituloDashboard = new Label();
            lblDescricaoDashboard = new Label();
            tlpIndicadores = new TableLayoutPanel();
            pnlPresentes = new Panel();
            pnlEntradas = new Panel();
            pnlSaidas = new Panel();
            pnlCadastros = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tlpDashboard.SuspendLayout();
            pnlCabecalhoDashboard.SuspendLayout();
            tlpIndicadores.SuspendLayout();
            pnlPresentes.SuspendLayout();
            pnlEntradas.SuspendLayout();
            pnlSaidas.SuspendLayout();
            pnlCadastros.SuspendLayout();
            SuspendLayout();
            // 
            // tlpDashboard
            // 
            tlpDashboard.ColumnCount = 1;
            tlpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDashboard.Controls.Add(pnlCabecalhoDashboard, 0, 0);
            tlpDashboard.Controls.Add(tlpIndicadores, 0, 1);
            tlpDashboard.Dock = DockStyle.Fill;
            tlpDashboard.Location = new Point(0, 0);
            tlpDashboard.Margin = new Padding(0);
            tlpDashboard.Name = "tlpDashboard";
            tlpDashboard.Padding = new Padding(24);
            tlpDashboard.RowCount = 3;
            tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDashboard.Size = new Size(1000, 737);
            tlpDashboard.TabIndex = 0;
            // 
            // pnlCabecalhoDashboard
            // 
            pnlCabecalhoDashboard.BackColor = Color.Transparent;
            pnlCabecalhoDashboard.Controls.Add(lblDescricaoDashboard);
            pnlCabecalhoDashboard.Controls.Add(lblTituloDashboard);
            pnlCabecalhoDashboard.Dock = DockStyle.Fill;
            pnlCabecalhoDashboard.Location = new Point(24, 24);
            pnlCabecalhoDashboard.Margin = new Padding(0);
            pnlCabecalhoDashboard.Name = "pnlCabecalhoDashboard";
            pnlCabecalhoDashboard.Size = new Size(952, 80);
            pnlCabecalhoDashboard.TabIndex = 0;
            // 
            // lblTituloDashboard
            // 
            lblTituloDashboard.AutoSize = true;
            lblTituloDashboard.Font = new Font("Segoe UI", 20F);
            lblTituloDashboard.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloDashboard.Location = new Point(0, 0);
            lblTituloDashboard.Name = "lblTituloDashboard";
            lblTituloDashboard.Size = new Size(147, 37);
            lblTituloDashboard.TabIndex = 0;
            lblTituloDashboard.Text = "Dashboard";
            // 
            // lblDescricaoDashboard
            // 
            lblDescricaoDashboard.AutoSize = true;
            lblDescricaoDashboard.ForeColor = Color.FromArgb(101, 112, 124);
            lblDescricaoDashboard.Location = new Point(0, 42);
            lblDescricaoDashboard.Name = "lblDescricaoDashboard";
            lblDescricaoDashboard.Size = new Size(290, 19);
            lblDescricaoDashboard.TabIndex = 1;
            lblDescricaoDashboard.Text = "\tVisão geral das entradas e saídas de visitantes";
            // 
            // tlpIndicadores
            // 
            tlpIndicadores.ColumnCount = 4;
            tlpIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpIndicadores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpIndicadores.Controls.Add(pnlPresentes, 0, 0);
            tlpIndicadores.Controls.Add(pnlEntradas, 1, 0);
            tlpIndicadores.Controls.Add(pnlSaidas, 2, 0);
            tlpIndicadores.Controls.Add(pnlCadastros, 3, 0);
            tlpIndicadores.Dock = DockStyle.Fill;
            tlpIndicadores.Location = new Point(24, 104);
            tlpIndicadores.Margin = new Padding(0, 0, 0, 16);
            tlpIndicadores.Name = "tlpIndicadores";
            tlpIndicadores.RowCount = 1;
            tlpIndicadores.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpIndicadores.Size = new Size(952, 104);
            tlpIndicadores.TabIndex = 1;
            // 
            // pnlPresentes
            // 
            pnlPresentes.BackColor = Color.White;
            pnlPresentes.BorderStyle = BorderStyle.FixedSingle;
            pnlPresentes.Controls.Add(label5);
            pnlPresentes.Controls.Add(label1);
            pnlPresentes.Dock = DockStyle.Fill;
            pnlPresentes.Location = new Point(6, 0);
            pnlPresentes.Margin = new Padding(6, 0, 6, 0);
            pnlPresentes.Name = "pnlPresentes";
            pnlPresentes.Size = new Size(226, 104);
            pnlPresentes.TabIndex = 0;
            // 
            // pnlEntradas
            // 
            pnlEntradas.BackColor = Color.White;
            pnlEntradas.BorderStyle = BorderStyle.FixedSingle;
            pnlEntradas.Controls.Add(label6);
            pnlEntradas.Controls.Add(label2);
            pnlEntradas.Dock = DockStyle.Fill;
            pnlEntradas.Location = new Point(244, 0);
            pnlEntradas.Margin = new Padding(6, 0, 6, 0);
            pnlEntradas.Name = "pnlEntradas";
            pnlEntradas.Size = new Size(226, 104);
            pnlEntradas.TabIndex = 1;
            // 
            // pnlSaidas
            // 
            pnlSaidas.BackColor = Color.White;
            pnlSaidas.BorderStyle = BorderStyle.FixedSingle;
            pnlSaidas.Controls.Add(label7);
            pnlSaidas.Controls.Add(label3);
            pnlSaidas.Dock = DockStyle.Fill;
            pnlSaidas.Location = new Point(482, 0);
            pnlSaidas.Margin = new Padding(6, 0, 6, 0);
            pnlSaidas.Name = "pnlSaidas";
            pnlSaidas.Size = new Size(226, 104);
            pnlSaidas.TabIndex = 2;
            // 
            // pnlCadastros
            // 
            pnlCadastros.BackColor = Color.White;
            pnlCadastros.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastros.Controls.Add(label8);
            pnlCadastros.Controls.Add(label4);
            pnlCadastros.Dock = DockStyle.Fill;
            pnlCadastros.Location = new Point(720, 0);
            pnlCadastros.Margin = new Padding(6, 0, 6, 0);
            pnlCadastros.Name = "pnlCadastros";
            pnlCadastros.Size = new Size(226, 104);
            pnlCadastros.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 41);
            label3.Name = "label3";
            label3.Size = new Size(45, 19);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 38);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 38);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-1, 38);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 1;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 13);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 1;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 16);
            label8.Name = "label8";
            label8.Size = new Size(45, 19);
            label8.TabIndex = 1;
            label8.Text = "label8";
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 245, 247);
            Controls.Add(tlpDashboard);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(0);
            Name = "ucDashboard";
            Size = new Size(1000, 737);
            tlpDashboard.ResumeLayout(false);
            pnlCabecalhoDashboard.ResumeLayout(false);
            pnlCabecalhoDashboard.PerformLayout();
            tlpIndicadores.ResumeLayout(false);
            pnlPresentes.ResumeLayout(false);
            pnlPresentes.PerformLayout();
            pnlEntradas.ResumeLayout(false);
            pnlEntradas.PerformLayout();
            pnlSaidas.ResumeLayout(false);
            pnlSaidas.PerformLayout();
            pnlCadastros.ResumeLayout(false);
            pnlCadastros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpDashboard;
        private Panel pnlCabecalhoDashboard;
        private Label lblDescricaoDashboard;
        private Label lblTituloDashboard;
        private TableLayoutPanel tlpIndicadores;
        private Panel pnlPresentes;
        private Panel pnlEntradas;
        private Panel pnlSaidas;
        private Panel pnlCadastros;
        private Label label5;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label7;
        private Label label3;
        private Label label8;
        private Label label4;
    }
}
