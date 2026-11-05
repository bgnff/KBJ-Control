namespace KBJK_Control.Telas.Historico
{
    partial class ucHistorico
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpHistorico = new TableLayoutPanel();
            pnlCabecalhoHistorico = new Panel();
            lblDescricaoHistorico = new Label();
            lblTituloHistorico = new Label();
            tlpFiltrosHistorico = new TableLayoutPanel();
            lblPesquisaHistorico = new Label();
            lblDataInicial = new Label();
            lblDataFinal = new Label();
            lblSituacaoHistorico = new Label();
            txtPesquisaHistorico = new TextBox();
            dtpDataInicial = new DateTimePicker();
            dtpDataFinal = new DateTimePicker();
            cmbSituacaoHistorico = new ComboBox();
            btnFiltrarHistorico = new Button();
            dgvHistorico = new DataGridView();
            colVisitante = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colEmpresa = new DataGridViewTextBoxColumn();
            colDestino = new DataGridViewTextBoxColumn();
            colEntrada = new DataGridViewTextBoxColumn();
            colSaida = new DataGridViewTextBoxColumn();
            colSituacao = new DataGridViewTextBoxColumn();
            colDetalhes = new DataGridViewButtonColumn();
            label1 = new Label();
            tlpHistorico.SuspendLayout();
            pnlCabecalhoHistorico.SuspendLayout();
            tlpFiltrosHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // tlpHistorico
            // 
            tlpHistorico.ColumnCount = 1;
            tlpHistorico.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHistorico.Controls.Add(pnlCabecalhoHistorico, 0, 0);
            tlpHistorico.Controls.Add(tlpFiltrosHistorico, 0, 1);
            tlpHistorico.Controls.Add(dgvHistorico, 0, 2);
            tlpHistorico.Controls.Add(label1, 0, 3);
            tlpHistorico.Dock = DockStyle.Fill;
            tlpHistorico.Location = new Point(0, 0);
            tlpHistorico.Margin = new Padding(0);
            tlpHistorico.Name = "tlpHistorico";
            tlpHistorico.Padding = new Padding(24);
            tlpHistorico.RowCount = 4;
            tlpHistorico.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpHistorico.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tlpHistorico.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHistorico.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpHistorico.Size = new Size(1000, 700);
            tlpHistorico.TabIndex = 0;
            // 
            // pnlCabecalhoHistorico
            // 
            pnlCabecalhoHistorico.Controls.Add(lblDescricaoHistorico);
            pnlCabecalhoHistorico.Controls.Add(lblTituloHistorico);
            pnlCabecalhoHistorico.Dock = DockStyle.Fill;
            pnlCabecalhoHistorico.Location = new Point(24, 24);
            pnlCabecalhoHistorico.Margin = new Padding(0);
            pnlCabecalhoHistorico.Name = "pnlCabecalhoHistorico";
            pnlCabecalhoHistorico.Size = new Size(952, 72);
            pnlCabecalhoHistorico.TabIndex = 0;
            // 
            // lblDescricaoHistorico
            // 
            lblDescricaoHistorico.AutoSize = true;
            lblDescricaoHistorico.ForeColor = Color.FromArgb(101, 112, 124);
            lblDescricaoHistorico.Location = new Point(0, 42);
            lblDescricaoHistorico.Name = "lblDescricaoHistorico";
            lblDescricaoHistorico.Size = new Size(269, 19);
            lblDescricaoHistorico.TabIndex = 1;
            lblDescricaoHistorico.Text = "Consulte as entradas e saídas de visitantes";
            // 
            // lblTituloHistorico
            // 
            lblTituloHistorico.AutoSize = true;
            lblTituloHistorico.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloHistorico.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloHistorico.Location = new Point(0, 0);
            lblTituloHistorico.Name = "lblTituloHistorico";
            lblTituloHistorico.Size = new Size(135, 37);
            lblTituloHistorico.TabIndex = 0;
            lblTituloHistorico.Text = "Histórico";
            // 
            // tlpFiltrosHistorico
            // 
            tlpFiltrosHistorico.ColumnCount = 5;
            tlpFiltrosHistorico.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tlpFiltrosHistorico.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tlpFiltrosHistorico.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
            tlpFiltrosHistorico.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpFiltrosHistorico.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFiltrosHistorico.Controls.Add(lblPesquisaHistorico, 0, 0);
            tlpFiltrosHistorico.Controls.Add(lblDataInicial, 1, 0);
            tlpFiltrosHistorico.Controls.Add(lblDataFinal, 2, 0);
            tlpFiltrosHistorico.Controls.Add(lblSituacaoHistorico, 3, 0);
            tlpFiltrosHistorico.Controls.Add(txtPesquisaHistorico, 0, 1);
            tlpFiltrosHistorico.Controls.Add(dtpDataInicial, 1, 1);
            tlpFiltrosHistorico.Controls.Add(dtpDataFinal, 2, 1);
            tlpFiltrosHistorico.Controls.Add(cmbSituacaoHistorico, 3, 1);
            tlpFiltrosHistorico.Controls.Add(btnFiltrarHistorico, 4, 1);
            tlpFiltrosHistorico.Dock = DockStyle.Fill;
            tlpFiltrosHistorico.Location = new Point(24, 96);
            tlpFiltrosHistorico.Margin = new Padding(0);
            tlpFiltrosHistorico.Name = "tlpFiltrosHistorico";
            tlpFiltrosHistorico.RowCount = 2;
            tlpFiltrosHistorico.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpFiltrosHistorico.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFiltrosHistorico.Size = new Size(952, 100);
            tlpFiltrosHistorico.TabIndex = 1;
            // 
            // lblPesquisaHistorico
            // 
            lblPesquisaHistorico.AutoSize = true;
            lblPesquisaHistorico.Location = new Point(3, 0);
            lblPesquisaHistorico.Name = "lblPesquisaHistorico";
            lblPesquisaHistorico.Size = new Size(140, 19);
            lblPesquisaHistorico.TabIndex = 0;
            lblPesquisaHistorico.Text = "Nome ou documento";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(363, 0);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(75, 19);
            lblDataInicial.TabIndex = 1;
            lblDataInicial.Text = "Data inicial";
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(508, 0);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(67, 19);
            lblDataFinal.TabIndex = 2;
            lblDataFinal.Text = "Data final";
            // 
            // lblSituacaoHistorico
            // 
            lblSituacaoHistorico.AutoSize = true;
            lblSituacaoHistorico.Location = new Point(653, 0);
            lblSituacaoHistorico.Name = "lblSituacaoHistorico";
            lblSituacaoHistorico.Size = new Size(60, 19);
            lblSituacaoHistorico.TabIndex = 3;
            lblSituacaoHistorico.Text = "Situação";
            // 
            // txtPesquisaHistorico
            // 
            txtPesquisaHistorico.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisaHistorico.Location = new Point(3, 34);
            txtPesquisaHistorico.Margin = new Padding(3, 6, 12, 0);
            txtPesquisaHistorico.Name = "txtPesquisaHistorico";
            txtPesquisaHistorico.PlaceholderText = "Pesquise por nome ou documento";
            txtPesquisaHistorico.Size = new Size(340, 25);
            txtPesquisaHistorico.TabIndex = 4;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(363, 34);
            dtpDataInicial.Margin = new Padding(3, 6, 12, 0);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(130, 25);
            dtpDataInicial.TabIndex = 5;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(508, 34);
            dtpDataFinal.Margin = new Padding(3, 6, 12, 0);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(130, 25);
            dtpDataFinal.TabIndex = 6;
            // 
            // cmbSituacaoHistorico
            // 
            cmbSituacaoHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSituacaoHistorico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSituacaoHistorico.FormattingEnabled = true;
            cmbSituacaoHistorico.Items.AddRange(new object[] { "Todas", "Em andamento", "Encerrada" });
            cmbSituacaoHistorico.Location = new Point(653, 34);
            cmbSituacaoHistorico.Margin = new Padding(3, 6, 12, 0);
            cmbSituacaoHistorico.Name = "cmbSituacaoHistorico";
            cmbSituacaoHistorico.Size = new Size(105, 25);
            cmbSituacaoHistorico.TabIndex = 7;
            cmbSituacaoHistorico.SelectedIndexChanged += cmbSituacaoHistorico_SelectedIndexChanged;
            // 
            // btnFiltrarHistorico
            // 
            btnFiltrarHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrarHistorico.BackColor = Color.FromArgb(212, 165, 30);
            btnFiltrarHistorico.Cursor = Cursors.Hand;
            btnFiltrarHistorico.FlatAppearance.BorderSize = 0;
            btnFiltrarHistorico.FlatStyle = FlatStyle.Flat;
            btnFiltrarHistorico.ForeColor = Color.FromArgb(48, 55, 65);
            btnFiltrarHistorico.Location = new Point(842, 28);
            btnFiltrarHistorico.Margin = new Padding(0);
            btnFiltrarHistorico.Name = "btnFiltrarHistorico";
            btnFiltrarHistorico.Size = new Size(110, 36);
            btnFiltrarHistorico.TabIndex = 8;
            btnFiltrarHistorico.Text = "Filtrar";
            btnFiltrarHistorico.UseVisualStyleBackColor = false;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.AllowUserToResizeRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.BackgroundColor = Color.White;
            dgvHistorico.BorderStyle = BorderStyle.None;
            dgvHistorico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 240, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(237, 240, 243);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorico.ColumnHeadersHeight = 40;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { colVisitante, colDocumento, colEmpresa, colDestino, colEntrada, colSaida, colSituacao, colDetalhes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 239, 203);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorico.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorico.Dock = DockStyle.Fill;
            dgvHistorico.EnableHeadersVisualStyles = false;
            dgvHistorico.GridColor = Color.FromArgb(212, 217, 223);
            dgvHistorico.Location = new Point(24, 196);
            dgvHistorico.Margin = new Padding(0);
            dgvHistorico.MultiSelect = false;
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersVisible = false;
            dgvHistorico.RowTemplate.Height = 36;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(952, 444);
            dgvHistorico.TabIndex = 2;
            dgvHistorico.CellFormatting += dgvHistorico_CellFormatting;
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
            colEntrada.FillWeight = 110F;
            colEntrada.HeaderText = "Entrada";
            colEntrada.Name = "colEntrada";
            colEntrada.ReadOnly = true;
            // 
            // colSaida
            // 
            colSaida.FillWeight = 110F;
            colSaida.HeaderText = "Saída";
            colSaida.Name = "colSaida";
            colSaida.ReadOnly = true;
            // 
            // colSituacao
            // 
            colSituacao.HeaderText = "Situação";
            colSituacao.Name = "colSituacao";
            colSituacao.ReadOnly = true;
            // 
            // colDetalhes
            // 
            colDetalhes.HeaderText = "Ação";
            colDetalhes.Name = "colDetalhes";
            colDetalhes.ReadOnly = true;
            colDetalhes.Text = "Ver detalhes";
            colDetalhes.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(101, 112, 124);
            label1.Location = new Point(24, 640);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 3;
            label1.Text = "Visitas encontradas: 0";
            // 
            // ucHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 245, 247);
            Controls.Add(tlpHistorico);
            Font = new Font("Segoe UI", 10F);
            Name = "ucHistorico";
            Size = new Size(1000, 700);
            tlpHistorico.ResumeLayout(false);
            tlpHistorico.PerformLayout();
            pnlCabecalhoHistorico.ResumeLayout(false);
            pnlCabecalhoHistorico.PerformLayout();
            tlpFiltrosHistorico.ResumeLayout(false);
            tlpFiltrosHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpHistorico;
        private Panel pnlCabecalhoHistorico;
        private Label lblDescricaoHistorico;
        private Label lblTituloHistorico;
        private TableLayoutPanel tlpFiltrosHistorico;
        private Label lblPesquisaHistorico;
        private Label lblDataInicial;
        private Label lblDataFinal;
        private Label lblSituacaoHistorico;
        private TextBox txtPesquisaHistorico;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFinal;
        private ComboBox cmbSituacaoHistorico;
        private Button btnFiltrarHistorico;
        private DataGridView dgvHistorico;
        private DataGridViewTextBoxColumn colVisitante;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colEmpresa;
        private DataGridViewTextBoxColumn colDestino;
        private DataGridViewTextBoxColumn colEntrada;
        private DataGridViewTextBoxColumn colSaida;
        private DataGridViewTextBoxColumn colSituacao;
        private DataGridViewButtonColumn colDetalhes;
        private Label label1;
    }
}
