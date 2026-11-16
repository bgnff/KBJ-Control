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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpRecepcao = new TableLayoutPanel();
            pnlRow1 = new Panel();
            btnREntrada = new Button();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlRow2 = new Panel();
            btnPesquisarRecepcao2 = new Button();
            pnlCampoPesquisa = new KBJK_Control.Controles.CampoArredondado();
            txtPesquisa = new TextBox();
            pnlTabelaPresentes = new KBJK_Control.Controles.TabelaArredondada();
            dgvPresentes = new DataGridView();
            colVisitante = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colEmpresa = new DataGridViewTextBoxColumn();
            colDestino = new DataGridViewTextBoxColumn();
            colEntrada = new DataGridViewTextBoxColumn();
            colSituacao = new DataGridViewTextBoxColumn();
            colSaida = new DataGridViewButtonColumn();
            lblTotalPresentes = new Label();
            tlpRecepcao.SuspendLayout();
            pnlRow1.SuspendLayout();
            pnlRow2.SuspendLayout();
            pnlCampoPesquisa.SuspendLayout();
            pnlTabelaPresentes.SuspendLayout();
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
            tlpRecepcao.Controls.Add(pnlTabelaPresentes, 0, 2);
            tlpRecepcao.Controls.Add(lblTotalPresentes, 0, 3);
            tlpRecepcao.Dock = DockStyle.Fill;
            tlpRecepcao.Location = new Point(0, 0);
            tlpRecepcao.Margin = new Padding(0);
            tlpRecepcao.Name = "tlpRecepcao";
            tlpRecepcao.Padding = new Padding(24);
            tlpRecepcao.RowCount = 5;
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpRecepcao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            lblDescricao.Size = new Size(321, 23);
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
            lblTitulo.Size = new Size(169, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Recepção";
            // 
            // pnlRow2
            // 
            pnlRow2.BackColor = Color.Transparent;
            pnlRow2.Controls.Add(btnPesquisarRecepcao2);
            pnlRow2.Controls.Add(pnlCampoPesquisa);
            pnlRow2.Dock = DockStyle.Fill;
            pnlRow2.Location = new Point(27, 109);
            pnlRow2.Name = "pnlRow2";
            pnlRow2.Size = new Size(1046, 67);
            pnlRow2.TabIndex = 1;
            // 
            // btnPesquisarRecepcao2
            // 
            btnPesquisarRecepcao2.BackColor = Color.FromArgb(212, 165, 30);
            btnPesquisarRecepcao2.Cursor = Cursors.Hand;
            btnPesquisarRecepcao2.FlatAppearance.BorderColor = Color.FromArgb(212, 165, 30);
            btnPesquisarRecepcao2.FlatStyle = FlatStyle.Flat;
            btnPesquisarRecepcao2.ForeColor = Color.FromArgb(48, 55, 65);
            btnPesquisarRecepcao2.Location = new Point(368, 6);
            btnPesquisarRecepcao2.Name = "btnPesquisarRecepcao2";
            btnPesquisarRecepcao2.Size = new Size(110, 46);
            btnPesquisarRecepcao2.TabIndex = 4;
            btnPesquisarRecepcao2.Text = "Pesquisar";
            btnPesquisarRecepcao2.UseVisualStyleBackColor = false;
            btnPesquisarRecepcao2.Click += btnPesquisarRecepcao2_Click;
            // 
            // pnlCampoPesquisa
            // 
            pnlCampoPesquisa.BackColor = Color.White;
            pnlCampoPesquisa.Controls.Add(txtPesquisa);
            pnlCampoPesquisa.Location = new Point(3, 6);
            pnlCampoPesquisa.Name = "pnlCampoPesquisa";
            pnlCampoPesquisa.Padding = new Padding(1);
            pnlCampoPesquisa.Raio = 8;
            pnlCampoPesquisa.Size = new Size(340, 36);
            pnlCampoPesquisa.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisa.BackColor = SystemColors.ControlLightLight;
            txtPesquisa.BorderStyle = BorderStyle.None;
            txtPesquisa.ForeColor = Color.FromArgb(48, 55, 65);
            txtPesquisa.Location = new Point(11, 7);
            txtPesquisa.Margin = new Padding(0);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquise por nome ou documento";
            txtPesquisa.Size = new Size(304, 23);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // pnlTabelaPresentes
            // 
            pnlTabelaPresentes.BackColor = Color.White;
            pnlTabelaPresentes.Controls.Add(dgvPresentes);
            pnlTabelaPresentes.Dock = DockStyle.Fill;
            pnlTabelaPresentes.Location = new Point(24, 179);
            pnlTabelaPresentes.Margin = new Padding(0);
            pnlTabelaPresentes.Name = "pnlTabelaPresentes";
            pnlTabelaPresentes.Padding = new Padding(1);
            pnlTabelaPresentes.Size = new Size(1052, 473);
            pnlTabelaPresentes.TabIndex = 2;
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
            dgvPresentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 34, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(20, 34, 55);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPresentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPresentes.ColumnHeadersHeight = 40;
            dgvPresentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPresentes.Columns.AddRange(new DataGridViewColumn[] { colVisitante, colDocumento, colEmpresa, colDestino, colEntrada, colSituacao, colSaida });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 239, 203);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPresentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPresentes.Dock = DockStyle.Fill;
            dgvPresentes.EnableHeadersVisualStyles = false;
            dgvPresentes.GridColor = Color.FromArgb(212, 217, 223);
            dgvPresentes.Location = new Point(1, 1);
            dgvPresentes.Margin = new Padding(0);
            dgvPresentes.MultiSelect = false;
            dgvPresentes.Name = "dgvPresentes";
            dgvPresentes.ReadOnly = true;
            dgvPresentes.RowHeadersVisible = false;
            dgvPresentes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPresentes.RowTemplate.Height = 36;
            dgvPresentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresentes.Size = new Size(1050, 471);
            dgvPresentes.TabIndex = 2;
            dgvPresentes.CellContentClick += dgvPresentes_CellContentClick;
            // 
            // colVisitante
            // 
            colVisitante.FillWeight = 140F;
            colVisitante.HeaderText = "Visitante";
            colVisitante.MinimumWidth = 6;
            colVisitante.Name = "colVisitante";
            colVisitante.ReadOnly = true;
            // 
            // colDocumento
            // 
            colDocumento.FillWeight = 110F;
            colDocumento.HeaderText = "Documento";
            colDocumento.MinimumWidth = 6;
            colDocumento.Name = "colDocumento";
            colDocumento.ReadOnly = true;
            // 
            // colEmpresa
            // 
            colEmpresa.FillWeight = 120F;
            colEmpresa.HeaderText = "Empresa de origem";
            colEmpresa.MinimumWidth = 6;
            colEmpresa.Name = "colEmpresa";
            colEmpresa.ReadOnly = true;
            // 
            // colDestino
            // 
            colDestino.FillWeight = 150F;
            colDestino.HeaderText = "Pessoa ou setor visitado";
            colDestino.MinimumWidth = 6;
            colDestino.Name = "colDestino";
            colDestino.ReadOnly = true;
            // 
            // colEntrada
            // 
            colEntrada.HeaderText = "Entrada";
            colEntrada.MinimumWidth = 6;
            colEntrada.Name = "colEntrada";
            colEntrada.ReadOnly = true;
            // 
            // colSituacao
            // 
            colSituacao.FillWeight = 90F;
            colSituacao.HeaderText = "Situação";
            colSituacao.MinimumWidth = 6;
            colSituacao.Name = "colSituacao";
            colSituacao.ReadOnly = true;
            // 
            // colSaida
            // 
            colSaida.HeaderText = "Ação";
            colSaida.MinimumWidth = 6;
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
            lblTotalPresentes.Location = new Point(27, 661);
            lblTotalPresentes.Name = "lblTotalPresentes";
            lblTotalPresentes.Size = new Size(184, 23);
            lblTotalPresentes.TabIndex = 3;
            lblTotalPresentes.Text = "Visitantes presentes : 0";
            // 
            // ucRecepcao
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
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
            pnlCampoPesquisa.ResumeLayout(false);
            pnlCampoPesquisa.PerformLayout();
            pnlTabelaPresentes.ResumeLayout(false);
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
        private DataGridView dgvPresentes;
        private KBJK_Control.Controles.TabelaArredondada pnlTabelaPresentes;
        private Label lblTotalPresentes;
        private DataGridViewTextBoxColumn colVisitante;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colEmpresa;
        private DataGridViewTextBoxColumn colDestino;
        private DataGridViewTextBoxColumn colEntrada;
        private DataGridViewTextBoxColumn colSituacao;
        private DataGridViewButtonColumn colSaida;
        private Controles.CampoArredondado pnlCampoPesquisa;
        private Button btnPesquisarRecepcao2;
    }
}
