namespace KBJK_Control.Telas.Recepcao
{
    partial class ucRecepcao
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpRecepcao = new TableLayoutPanel();
            pnlRow1 = new Panel();
            btnREntrada = new Button();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlRow2 = new Panel();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            dgvPresentes = new DataGridView();
            colVisitante = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colEmpresa = new DataGridViewTextBoxColumn();
            colDestino = new DataGridViewTextBoxColumn();
            colEntrada = new DataGridViewTextBoxColumn();
            colSaida = new DataGridViewButtonColumn();
            lblTotalPresentes = new Label();
            tlpRecepcao.SuspendLayout();
            pnlRow1.SuspendLayout();
            pnlRow2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresentes).BeginInit();
            SuspendLayout();
            // 
            // tlpRecepcao
            // 
            tlpRecepcao.AutoSize = true;
            tlpRecepcao.ColumnCount = 1;
            tlpRecepcao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRecepcao.Controls.Add(pnlRow1, 0, 0);
            tlpRecepcao.Controls.Add(pnlRow2, 0, 1);
            tlpRecepcao.Controls.Add(dgvPresentes, 0, 2);
            tlpRecepcao.Controls.Add(lblTotalPresentes, 0, 3);
            tlpRecepcao.Dock = DockStyle.Fill;
            tlpRecepcao.Location = new Point(0, 0);
            tlpRecepcao.Margin = new Padding(0);
            tlpRecepcao.Name = "tlpRecepcao";
            tlpRecepcao.Padding = new Padding(24);
            tlpRecepcao.RowCount = 4;
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpRecepcao.Size = new Size(1100, 737);
            tlpRecepcao.TabIndex = 0;
            // 
            // pnlRow1
            // 
            pnlRow1.BackColor = Color.Transparent;
            pnlRow1.Controls.Add(btnREntrada);
            pnlRow1.Controls.Add(lblDescricao);
            pnlRow1.Controls.Add(lblTitulo);
            pnlRow1.Dock = DockStyle.Fill;
            pnlRow1.Location = new Point(24, 24);
            pnlRow1.Margin = new Padding(0);
            pnlRow1.Name = "pnlRow1";
            pnlRow1.Size = new Size(1052, 82);
            pnlRow1.TabIndex = 0;
            // 
            // btnREntrada
            // 
            btnREntrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnREntrada.BackColor = Color.FromArgb(212, 165, 30);
            btnREntrada.Cursor = Cursors.Hand;
            btnREntrada.FlatAppearance.BorderSize = 0;
            btnREntrada.FlatStyle = FlatStyle.Flat;
            btnREntrada.Font = new Font("Arial", 10F);
            btnREntrada.ForeColor = Color.Black;
            btnREntrada.Location = new Point(836, 16);
            btnREntrada.Name = "btnREntrada";
            btnREntrada.Size = new Size(160, 36);
            btnREntrada.TabIndex = 3;
            btnREntrada.Text = "Registrar Entrada";
            btnREntrada.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 10F);
            lblDescricao.ForeColor = Color.FromArgb(101, 112, 124);
            lblDescricao.Location = new Point(0, 42);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(258, 19);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Controle de entrada e saída de visitantes";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(48, 55, 65);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recepção";
            // 
            // pnlRow2
            // 
            pnlRow2.BackColor = Color.Transparent;
            pnlRow2.Controls.Add(txtPesquisa);
            pnlRow2.Controls.Add(btnPesquisar);
            pnlRow2.Dock = DockStyle.Fill;
            pnlRow2.Location = new Point(27, 109);
            pnlRow2.Name = "pnlRow2";
            pnlRow2.Size = new Size(1046, 67);
            pnlRow2.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.White;
            txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisa.ForeColor = Color.FromArgb(48, 55, 65);
            txtPesquisa.Location = new Point(3, 14);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquise por nome ou documento";
            txtPesquisa.Size = new Size(340, 25);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.White;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderColor = Color.FromArgb(212, 217, 223);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.FromArgb(48, 55, 65);
            btnPesquisar.Location = new Point(349, 6);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(110, 36);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dgvPresentes
            // 
            dgvPresentes.AllowUserToAddRows = false;
            dgvPresentes.AllowUserToDeleteRows = false;
            dgvPresentes.AllowUserToResizeRows = false;
            dgvPresentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresentes.BackgroundColor = Color.White;
            dgvPresentes.BorderStyle = BorderStyle.None;
            dgvPresentes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPresentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(237, 240, 243);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPresentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPresentes.ColumnHeadersHeight = 40;
            dgvPresentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPresentes.Columns.AddRange(new DataGridViewColumn[] { colVisitante, colDocumento, colEmpresa, colDestino, colEntrada, colSaida });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(250, 239, 203);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPresentes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPresentes.Dock = DockStyle.Fill;
            dgvPresentes.EnableHeadersVisualStyles = false;
            dgvPresentes.GridColor = Color.FromArgb(212, 217, 223);
            dgvPresentes.Location = new Point(24, 179);
            dgvPresentes.Margin = new Padding(0);
            dgvPresentes.MultiSelect = false;
            dgvPresentes.Name = "dgvPresentes";
            dgvPresentes.ReadOnly = true;
            dgvPresentes.RowHeadersVisible = false;
            dgvPresentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPresentes.RowTemplate.Height = 36;
            dgvPresentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresentes.Size = new Size(1052, 493);
            dgvPresentes.TabIndex = 2;
            // 
            // colVisitante
            // 
            colVisitante.FillWeight = 140F;
            colVisitante.HeaderText = "Visitante";
            colVisitante.Name = "colVisitante";
            colVisitante.ReadOnly = true;
            // 
            // colDocumento
            // 
            colDocumento.FillWeight = 110F;
            colDocumento.HeaderText = "Documento";
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            // 
            // colEmpresa
            // 
            colEmpresa.FillWeight = 120F;
            colEmpresa.HeaderText = "Empresa de origem";
            colEmpresa.Name = "colEmpresa";
            colEmpresa.ReadOnly = true;
            // 
            // colDestino
            // 
            colDestino.FillWeight = 150F;
            colDestino.HeaderText = "Pessoa ou setor visitado";
            colDestino.Name = "colDestino";
            colDestino.ReadOnly = true;
            // 
            // colEntrada
            // 
            colEntrada.HeaderText = "Entrada";
            colEntrada.Name = "colEntrada";
            colEntrada.ReadOnly = true;
            // 
            // colSaida
            // 
            colSaida.HeaderText = "Ação";
            colSaida.Name = "colSaida";
            colSaida.ReadOnly = true;
            colSaida.Text = "Registrar saída";
            colSaida.UseColumnTextForButtonValue = true;
            // 
            // lblTotalPresentes
            // 
            lblTotalPresentes.Anchor = AnchorStyles.Left;
            lblTotalPresentes.AutoSize = true;
            lblTotalPresentes.ForeColor = Color.FromArgb(101, 112, 124);
            lblTotalPresentes.Location = new Point(27, 683);
            lblTotalPresentes.Name = "lblTotalPresentes";
            lblTotalPresentes.Size = new Size(150, 19);
            lblTotalPresentes.TabIndex = 3;
            lblTotalPresentes.Text = "Visitantes presentes : 0";
            // 
            // ucRecepcao
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            Controls.Add(tlpRecepcao);
            Font = new Font("Segoe UI", 10F);
            Name = "ucRecepcao";
            Size = new Size(1100, 737);
            tlpRecepcao.ResumeLayout(false);
            tlpRecepcao.PerformLayout();
            pnlRow1.ResumeLayout(false);
            pnlRow1.PerformLayout();
            pnlRow2.ResumeLayout(false);
            pnlRow2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpRecepcao;
        private Panel pnlRow1;
        private Label lblTitulo;
        private Button btnREntrada;
        private Label lblDescricao;
        private Panel pnlRow2;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private DataGridView dgvPresentes;
        private Label lblTotalPresentes;
        private DataGridViewTextBoxColumn colVisitante;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colEmpresa;
        private DataGridViewTextBoxColumn colDestino;
        private DataGridViewTextBoxColumn colEntrada;
        private DataGridViewButtonColumn colSaida;
    }
}
