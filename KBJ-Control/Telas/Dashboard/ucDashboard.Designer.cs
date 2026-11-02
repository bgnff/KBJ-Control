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
            lblDescricaoDashboard = new Label();
            lblTituloDashboard = new Label();
            tlpIndicadores = new TableLayoutPanel();
            pnlPresentes = new Panel();
            lblTotalPresentes = new Label();
            lblTituloPresentes = new Label();
            pnlEntradas = new Panel();
            lblTotalEntradas = new Label();
            lblTituloEntradas = new Label();
            pnlSaidas = new Panel();
            lblTotalSaidas = new Label();
            lblTituloSaidas = new Label();
            pnlCadastros = new Panel();
            lblTotalCadastros = new Label();
            lblTituloCadastros = new Label();
            tlpVisitasDashboard = new TableLayoutPanel();
            lblTituloVisitas = new Label();
            dgvVisitasHoje = new DataGridView();
            tlpDashboard.SuspendLayout();
            pnlCabecalhoDashboard.SuspendLayout();
            tlpIndicadores.SuspendLayout();
            pnlPresentes.SuspendLayout();
            pnlEntradas.SuspendLayout();
            pnlSaidas.SuspendLayout();
            pnlCadastros.SuspendLayout();
            tlpVisitasDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitasHoje).BeginInit();
            SuspendLayout();
            // 
            // tlpDashboard
            // 
            tlpDashboard.ColumnCount = 1;
            tlpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDashboard.Controls.Add(pnlCabecalhoDashboard, 0, 0);
            tlpDashboard.Controls.Add(tlpIndicadores, 0, 1);
            tlpDashboard.Controls.Add(tlpVisitasDashboard, 0, 2);
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
            pnlPresentes.Controls.Add(lblTituloPresentes);
            pnlPresentes.Controls.Add(lblTotalPresentes);
            pnlPresentes.Dock = DockStyle.Fill;
            pnlPresentes.Location = new Point(6, 0);
            pnlPresentes.Margin = new Padding(6, 0, 6, 0);
            pnlPresentes.Name = "pnlPresentes";
            pnlPresentes.Size = new Size(226, 104);
            pnlPresentes.TabIndex = 0;
            // 
            // lblTotalPresentes
            // 
            lblTotalPresentes.AutoSize = true;
            lblTotalPresentes.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalPresentes.Location = new Point(12, 38);
            lblTotalPresentes.Name = "lblTotalPresentes";
            lblTotalPresentes.Size = new Size(38, 45);
            lblTotalPresentes.TabIndex = 1;
            lblTotalPresentes.Text = "0";
            // 
            // lblTituloPresentes
            // 
            lblTituloPresentes.AutoSize = true;
            lblTituloPresentes.Font = new Font("Segoe UI", 10F);
            lblTituloPresentes.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloPresentes.Location = new Point(12, 12);
            lblTituloPresentes.Name = "lblTituloPresentes";
            lblTituloPresentes.Size = new Size(107, 19);
            lblTituloPresentes.TabIndex = 0;
            lblTituloPresentes.Text = "Presentes agora";
            // 
            // pnlEntradas
            // 
            pnlEntradas.BackColor = Color.White;
            pnlEntradas.BorderStyle = BorderStyle.FixedSingle;
            pnlEntradas.Controls.Add(lblTituloEntradas);
            pnlEntradas.Controls.Add(lblTotalEntradas);
            pnlEntradas.Dock = DockStyle.Fill;
            pnlEntradas.Location = new Point(244, 0);
            pnlEntradas.Margin = new Padding(6, 0, 6, 0);
            pnlEntradas.Name = "pnlEntradas";
            pnlEntradas.Size = new Size(226, 104);
            pnlEntradas.TabIndex = 1;
            // 
            // lblTotalEntradas
            // 
            lblTotalEntradas.AutoSize = true;
            lblTotalEntradas.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalEntradas.Location = new Point(12, 38);
            lblTotalEntradas.Name = "lblTotalEntradas";
            lblTotalEntradas.Size = new Size(38, 45);
            lblTotalEntradas.TabIndex = 1;
            lblTotalEntradas.Text = "0";
            // 
            // lblTituloEntradas
            // 
            lblTituloEntradas.AutoSize = true;
            lblTituloEntradas.Font = new Font("Segoe UI", 10F);
            lblTituloEntradas.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloEntradas.Location = new Point(12, 12);
            lblTituloEntradas.Name = "lblTituloEntradas";
            lblTituloEntradas.Size = new Size(92, 19);
            lblTituloEntradas.TabIndex = 0;
            lblTituloEntradas.Text = "Entradas hoje";
            // 
            // pnlSaidas
            // 
            pnlSaidas.BackColor = Color.White;
            pnlSaidas.BorderStyle = BorderStyle.FixedSingle;
            pnlSaidas.Controls.Add(lblTituloSaidas);
            pnlSaidas.Controls.Add(lblTotalSaidas);
            pnlSaidas.Dock = DockStyle.Fill;
            pnlSaidas.Location = new Point(482, 0);
            pnlSaidas.Margin = new Padding(6, 0, 6, 0);
            pnlSaidas.Name = "pnlSaidas";
            pnlSaidas.Size = new Size(226, 104);
            pnlSaidas.TabIndex = 2;
            // 
            // lblTotalSaidas
            // 
            lblTotalSaidas.AutoSize = true;
            lblTotalSaidas.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalSaidas.Location = new Point(12, 38);
            lblTotalSaidas.Name = "lblTotalSaidas";
            lblTotalSaidas.Size = new Size(38, 45);
            lblTotalSaidas.TabIndex = 1;
            lblTotalSaidas.Text = "0";
            // 
            // lblTituloSaidas
            // 
            lblTituloSaidas.AutoSize = true;
            lblTituloSaidas.Font = new Font("Segoe UI", 10F);
            lblTituloSaidas.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloSaidas.Location = new Point(12, 12);
            lblTituloSaidas.Name = "lblTituloSaidas";
            lblTituloSaidas.Size = new Size(77, 19);
            lblTituloSaidas.TabIndex = 0;
            lblTituloSaidas.Text = "Saídas hoje";
            // 
            // pnlCadastros
            // 
            pnlCadastros.BackColor = Color.White;
            pnlCadastros.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastros.Controls.Add(lblTituloCadastros);
            pnlCadastros.Controls.Add(lblTotalCadastros);
            pnlCadastros.Dock = DockStyle.Fill;
            pnlCadastros.Location = new Point(720, 0);
            pnlCadastros.Margin = new Padding(6, 0, 6, 0);
            pnlCadastros.Name = "pnlCadastros";
            pnlCadastros.Size = new Size(226, 104);
            pnlCadastros.TabIndex = 3;
            // 
            // lblTotalCadastros
            // 
            lblTotalCadastros.AutoSize = true;
            lblTotalCadastros.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalCadastros.Location = new Point(12, 38);
            lblTotalCadastros.Name = "lblTotalCadastros";
            lblTotalCadastros.Size = new Size(38, 45);
            lblTotalCadastros.TabIndex = 1;
            lblTotalCadastros.Text = "0";
            // 
            // lblTituloCadastros
            // 
            lblTituloCadastros.AutoSize = true;
            lblTituloCadastros.Font = new Font("Segoe UI", 10F);
            lblTituloCadastros.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloCadastros.Location = new Point(12, 12);
            lblTituloCadastros.Name = "lblTituloCadastros";
            lblTituloCadastros.Size = new Size(100, 19);
            lblTituloCadastros.TabIndex = 0;
            lblTituloCadastros.Text = "Cadastros hoje";
            // 
            // tlpVisitasDashboard
            // 
            tlpVisitasDashboard.ColumnCount = 1;
            tlpVisitasDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpVisitasDashboard.Controls.Add(lblTituloVisitas, 0, 0);
            tlpVisitasDashboard.Controls.Add(dgvVisitasHoje, 0, 1);
            tlpVisitasDashboard.Dock = DockStyle.Fill;
            tlpVisitasDashboard.Location = new Point(24, 224);
            tlpVisitasDashboard.Margin = new Padding(0);
            tlpVisitasDashboard.Name = "tlpVisitasDashboard";
            tlpVisitasDashboard.RowCount = 2;
            tlpVisitasDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpVisitasDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVisitasDashboard.Size = new Size(952, 489);
            tlpVisitasDashboard.TabIndex = 2;
            // 
            // lblTituloVisitas
            // 
            lblTituloVisitas.AutoSize = true;
            lblTituloVisitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVisitas.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloVisitas.Location = new Point(3, 0);
            lblTituloVisitas.Name = "lblTituloVisitas";
            lblTituloVisitas.Size = new Size(121, 21);
            lblTituloVisitas.TabIndex = 0;
            lblTituloVisitas.Text = "Visitas de hoje";
            // 
            // dgvVisitasHoje
            // 
            dgvVisitasHoje.AllowUserToAddRows = false;
            dgvVisitasHoje.AllowUserToDeleteRows = false;
            dgvVisitasHoje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisitasHoje.BackgroundColor = Color.White;
            dgvVisitasHoje.BorderStyle = BorderStyle.None;
            dgvVisitasHoje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitasHoje.Dock = DockStyle.Fill;
            dgvVisitasHoje.Location = new Point(0, 40);
            dgvVisitasHoje.Margin = new Padding(0);
            dgvVisitasHoje.MultiSelect = false;
            dgvVisitasHoje.Name = "dgvVisitasHoje";
            dgvVisitasHoje.ReadOnly = true;
            dgvVisitasHoje.RowHeadersVisible = false;
            dgvVisitasHoje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitasHoje.Size = new Size(952, 449);
            dgvVisitasHoje.TabIndex = 1;
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
            tlpVisitasDashboard.ResumeLayout(false);
            tlpVisitasDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitasHoje).EndInit();
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
        private Label lblTotalPresentes;
        private Label lblTituloPresentes;
        private Label lblTotalEntradas;
        private Label lblTituloEntradas;
        private Label lblTotalSaidas;
        private Label lblTituloSaidas;
        private Label lblTotalCadastros;
        private Label lblTituloCadastros;
        private TableLayoutPanel tlpVisitasDashboard;
        private Label lblTituloVisitas;
        private DataGridView dgvVisitasHoje;
    }
}
