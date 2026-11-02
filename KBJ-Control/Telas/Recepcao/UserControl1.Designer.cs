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
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpRecepcao.Size = new Size(1100, 650);
            tlpRecepcao.TabIndex = 0;
            // 
            // pnlRow1
            // 
            pnlRow1.Controls.Add(btnREntrada);
            pnlRow1.Controls.Add(lblDescricao);
            pnlRow1.Controls.Add(lblTitulo);
            pnlRow1.Dock = DockStyle.Fill;
            pnlRow1.Location = new Point(24, 24);
            pnlRow1.Margin = new Padding(0);
            pnlRow1.Name = "pnlRow1";
            pnlRow1.Size = new Size(1052, 72);
            pnlRow1.TabIndex = 0;
            // 
            // btnREntrada
            // 
            btnREntrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnREntrada.BackColor = Color.Goldenrod;
            btnREntrada.Cursor = Cursors.Hand;
            btnREntrada.FlatAppearance.BorderSize = 0;
            btnREntrada.FlatStyle = FlatStyle.Flat;
            btnREntrada.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnREntrada.Location = new Point(836, 14);
            btnREntrada.Name = "btnREntrada";
            btnREntrada.Size = new Size(170, 32);
            btnREntrada.TabIndex = 3;
            btnREntrada.Text = "Registrar Entrada";
            btnREntrada.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(24, 57);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(219, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Controle de entrada e saída de visitantes";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(24, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recepção";
            // 
            // pnlRow2
            // 
            pnlRow2.Controls.Add(txtPesquisa);
            pnlRow2.Controls.Add(btnPesquisar);
            pnlRow2.Dock = DockStyle.Fill;
            pnlRow2.Location = new Point(27, 99);
            pnlRow2.Name = "pnlRow2";
            pnlRow2.Size = new Size(1046, 58);
            pnlRow2.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(21, 14);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = " Pesquise por nome ou documento";
            txtPesquisa.Size = new Size(325, 23);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(365, 14);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvPresentes
            // 
            dgvPresentes.AllowUserToAddRows = false;
            dgvPresentes.AllowUserToDeleteRows = false;
            dgvPresentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresentes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPresentes.BorderStyle = BorderStyle.None;
            dgvPresentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresentes.Columns.AddRange(new DataGridViewColumn[] { colVisitante, colDocumento, colEmpresa, colDestino, colEntrada, colSaida });
            dgvPresentes.Dock = DockStyle.Fill;
            dgvPresentes.Location = new Point(27, 163);
            dgvPresentes.MultiSelect = false;
            dgvPresentes.Name = "dgvPresentes";
            dgvPresentes.ReadOnly = true;
            dgvPresentes.RowHeadersVisible = false;
            dgvPresentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPresentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresentes.Size = new Size(1046, 424);
            dgvPresentes.TabIndex = 2;
            // 
            // colVisitante
            // 
            colVisitante.HeaderText = "Visitante";
            colVisitante.Name = "colVisitante";
            colVisitante.ReadOnly = true;
            // 
            // colDocumento
            // 
            colDocumento.HeaderText = "Documento";
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            // 
            // colEmpresa
            // 
            colEmpresa.HeaderText = "Empresa de origem";
            colEmpresa.Name = "colEmpresa";
            colEmpresa.ReadOnly = true;
            // 
            // colDestino
            // 
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
            colSaida.Resizable = DataGridViewTriState.True;
            colSaida.SortMode = DataGridViewColumnSortMode.Automatic;
            colSaida.ToolTipText = "Registrar saída ";
            colSaida.UseColumnTextForButtonValue = true;
            // 
            // lblTotalPresentes
            // 
            lblTotalPresentes.Anchor = AnchorStyles.Left;
            lblTotalPresentes.AutoSize = true;
            lblTotalPresentes.Location = new Point(27, 600);
            lblTotalPresentes.Name = "lblTotalPresentes";
            lblTotalPresentes.Size = new Size(116, 15);
            lblTotalPresentes.TabIndex = 3;
            lblTotalPresentes.Text = "Visitantes presentes :";
            // 
            // ucRecepcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpRecepcao);
            Name = "ucRecepcao";
            Size = new Size(1100, 650);
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
        private DataGridViewTextBoxColumn colVisitante;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colEmpresa;
        private DataGridViewTextBoxColumn colDestino;
        private DataGridViewTextBoxColumn colEntrada;
        private DataGridViewButtonColumn colSaida;
        private Label lblTotalPresentes;
    }
}
