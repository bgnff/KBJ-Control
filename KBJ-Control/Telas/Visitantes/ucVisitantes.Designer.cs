namespace KBJK_Control.Telas.Visitantes
{
    partial class ucVisitantes
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
            tlpVisitantes = new TableLayoutPanel();
            pnlCabecalhoVisitantes = new Panel();
            btnCadastrarVisitante = new Button();
            lblTituloVisitantes = new Label();
            lblDescricaoVisitantes = new Label();
            pnlPesquisaVisitantes = new Panel();
            btnPesquisarVisitantes = new Button();
            txtPesquisaVisitantes = new TextBox();
            dgvVisitantes = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colEmpresa = new DataGridViewTextBoxColumn();
            colSelecionarEntrada = new DataGridViewButtonColumn();
            lblTotalVisitantes = new Label();
            tlpVisitantes.SuspendLayout();
            pnlCabecalhoVisitantes.SuspendLayout();
            pnlPesquisaVisitantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).BeginInit();
            SuspendLayout();
            // 
            // tlpVisitantes
            // 
            tlpVisitantes.ColumnCount = 1;
            tlpVisitantes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpVisitantes.Controls.Add(pnlCabecalhoVisitantes, 0, 0);
            tlpVisitantes.Controls.Add(pnlPesquisaVisitantes, 0, 1);
            tlpVisitantes.Controls.Add(dgvVisitantes, 0, 2);
            tlpVisitantes.Controls.Add(lblTotalVisitantes, 0, 3);
            tlpVisitantes.Dock = DockStyle.Fill;
            tlpVisitantes.Location = new Point(0, 0);
            tlpVisitantes.Margin = new Padding(0);
            tlpVisitantes.Name = "tlpVisitantes";
            tlpVisitantes.Padding = new Padding(24);
            tlpVisitantes.RowCount = 4;
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpVisitantes.Size = new Size(1000, 700);
            tlpVisitantes.TabIndex = 0;
            // 
            // pnlCabecalhoVisitantes
            // 
            pnlCabecalhoVisitantes.Controls.Add(btnCadastrarVisitante);
            pnlCabecalhoVisitantes.Controls.Add(lblTituloVisitantes);
            pnlCabecalhoVisitantes.Controls.Add(lblDescricaoVisitantes);
            pnlCabecalhoVisitantes.Dock = DockStyle.Fill;
            pnlCabecalhoVisitantes.Location = new Point(24, 24);
            pnlCabecalhoVisitantes.Margin = new Padding(0);
            pnlCabecalhoVisitantes.Name = "pnlCabecalhoVisitantes";
            pnlCabecalhoVisitantes.Padding = new Padding(24);
            pnlCabecalhoVisitantes.Size = new Size(952, 72);
            pnlCabecalhoVisitantes.TabIndex = 0;
            // 
            // btnCadastrarVisitante
            // 
            btnCadastrarVisitante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrarVisitante.BackColor = Color.FromArgb(212, 165, 30);
            btnCadastrarVisitante.Cursor = Cursors.Hand;
            btnCadastrarVisitante.FlatAppearance.BorderSize = 0;
            btnCadastrarVisitante.FlatStyle = FlatStyle.Flat;
            btnCadastrarVisitante.ForeColor = Color.Black;
            btnCadastrarVisitante.Location = new Point(765, 17);
            btnCadastrarVisitante.Name = "btnCadastrarVisitante";
            btnCadastrarVisitante.Size = new Size(160, 36);
            btnCadastrarVisitante.TabIndex = 2;
            btnCadastrarVisitante.Text = "Cadastrar visitante";
            btnCadastrarVisitante.UseVisualStyleBackColor = false;
            // 
            // lblTituloVisitantes
            // 
            lblTituloVisitantes.AutoSize = true;
            lblTituloVisitantes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVisitantes.ForeColor = Color.FromArgb(48, 55, 65);
            lblTituloVisitantes.Location = new Point(0, 0);
            lblTituloVisitantes.Name = "lblTituloVisitantes";
            lblTituloVisitantes.Size = new Size(143, 37);
            lblTituloVisitantes.TabIndex = 0;
            lblTituloVisitantes.Text = "Visitantes";
            // 
            // lblDescricaoVisitantes
            // 
            lblDescricaoVisitantes.AutoSize = true;
            lblDescricaoVisitantes.ForeColor = Color.FromArgb(101, 112, 124);
            lblDescricaoVisitantes.Location = new Point(0, 42);
            lblDescricaoVisitantes.Name = "lblDescricaoVisitantes";
            lblDescricaoVisitantes.Size = new Size(285, 19);
            lblDescricaoVisitantes.TabIndex = 1;
            lblDescricaoVisitantes.Text = "Consulte e gerencie os visitantes cadastrados";
            // 
            // pnlPesquisaVisitantes
            // 
            pnlPesquisaVisitantes.Controls.Add(btnPesquisarVisitantes);
            pnlPesquisaVisitantes.Controls.Add(txtPesquisaVisitantes);
            pnlPesquisaVisitantes.Dock = DockStyle.Fill;
            pnlPesquisaVisitantes.Location = new Point(24, 96);
            pnlPesquisaVisitantes.Margin = new Padding(0);
            pnlPesquisaVisitantes.Name = "pnlPesquisaVisitantes";
            pnlPesquisaVisitantes.Size = new Size(952, 64);
            pnlPesquisaVisitantes.TabIndex = 1;
            // 
            // btnPesquisarVisitantes
            // 
            btnPesquisarVisitantes.BackColor = Color.FromArgb(212, 165, 30);
            btnPesquisarVisitantes.Cursor = Cursors.Hand;
            btnPesquisarVisitantes.FlatAppearance.BorderColor = Color.FromArgb(212, 165, 30);
            btnPesquisarVisitantes.FlatStyle = FlatStyle.Flat;
            btnPesquisarVisitantes.ForeColor = Color.FromArgb(48, 55, 65);
            btnPesquisarVisitantes.Location = new Point(352, 6);
            btnPesquisarVisitantes.Name = "btnPesquisarVisitantes";
            btnPesquisarVisitantes.Size = new Size(110, 36);
            btnPesquisarVisitantes.TabIndex = 1;
            btnPesquisarVisitantes.Text = "Pesquisar";
            btnPesquisarVisitantes.UseVisualStyleBackColor = false;
            // 
            // txtPesquisaVisitantes
            // 
            txtPesquisaVisitantes.BackColor = Color.White;
            txtPesquisaVisitantes.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisaVisitantes.ForeColor = Color.FromArgb(48, 55, 65);
            txtPesquisaVisitantes.Location = new Point(0, 12);
            txtPesquisaVisitantes.Name = "txtPesquisaVisitantes";
            txtPesquisaVisitantes.PlaceholderText = "Pesquise por nome ou documento";
            txtPesquisaVisitantes.Size = new Size(340, 25);
            txtPesquisaVisitantes.TabIndex = 0;
            // 
            // dgvVisitantes
            // 
            dgvVisitantes.AllowUserToAddRows = false;
            dgvVisitantes.AllowUserToDeleteRows = false;
            dgvVisitantes.AllowUserToResizeRows = false;
            dgvVisitantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisitantes.BackgroundColor = Color.White;
            dgvVisitantes.BorderStyle = BorderStyle.None;
            dgvVisitantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVisitantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 240, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(237, 240, 243);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVisitantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisitantes.ColumnHeadersHeight = 40;
            dgvVisitantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVisitantes.Columns.AddRange(new DataGridViewColumn[] { colNome, colDocumento, colEmpresa, colSelecionarEntrada });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 239, 203);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(48, 55, 65);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVisitantes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVisitantes.Dock = DockStyle.Fill;
            dgvVisitantes.EnableHeadersVisualStyles = false;
            dgvVisitantes.GridColor = Color.FromArgb(212, 217, 223);
            dgvVisitantes.Location = new Point(24, 160);
            dgvVisitantes.Margin = new Padding(0);
            dgvVisitantes.MultiSelect = false;
            dgvVisitantes.Name = "dgvVisitantes";
            dgvVisitantes.ReadOnly = true;
            dgvVisitantes.RowHeadersVisible = false;
            dgvVisitantes.RowTemplate.Height = 36;
            dgvVisitantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitantes.Size = new Size(952, 480);
            dgvVisitantes.TabIndex = 2;
            // 
            // colNome
            // 
            colNome.FillWeight = 140F;
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
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
            colEmpresa.FillWeight = 150F;
            colEmpresa.HeaderText = "Empresa de origem";
            colEmpresa.Name = "colEmpresa";
            colEmpresa.ReadOnly = true;
            // 
            // colSelecionarEntrada
            // 
            colSelecionarEntrada.FillWeight = 130F;
            colSelecionarEntrada.HeaderText = "Ação";
            colSelecionarEntrada.Name = "colSelecionarEntrada";
            colSelecionarEntrada.ReadOnly = true;
            colSelecionarEntrada.Text = "Selecionar para entrada";
            colSelecionarEntrada.UseColumnTextForButtonValue = true;
            // 
            // lblTotalVisitantes
            // 
            lblTotalVisitantes.Anchor = AnchorStyles.Left;
            lblTotalVisitantes.AutoSize = true;
            lblTotalVisitantes.ForeColor = Color.FromArgb(101, 112, 124);
            lblTotalVisitantes.Location = new Point(24, 648);
            lblTotalVisitantes.Margin = new Padding(0);
            lblTotalVisitantes.Name = "lblTotalVisitantes";
            lblTotalVisitantes.Size = new Size(160, 19);
            lblTotalVisitantes.TabIndex = 3;
            lblTotalVisitantes.Text = "Visitantes cadastrados: 0";
            // 
            // ucVisitantes
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(244, 245, 247);
            Controls.Add(tlpVisitantes);
            Font = new Font("Segoe UI", 10F);
            Name = "ucVisitantes";
            Size = new Size(1000, 700);
            tlpVisitantes.ResumeLayout(false);
            tlpVisitantes.PerformLayout();
            pnlCabecalhoVisitantes.ResumeLayout(false);
            pnlCabecalhoVisitantes.PerformLayout();
            pnlPesquisaVisitantes.ResumeLayout(false);
            pnlPesquisaVisitantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpVisitantes;
        private Panel pnlCabecalhoVisitantes;
        private Button btnCadastrarVisitante;
        private Label lblTituloVisitantes;
        private Label lblDescricaoVisitantes;
        private Panel pnlPesquisaVisitantes;
        private Button btnPesquisarVisitantes;
        private TextBox txtPesquisaVisitantes;
        private DataGridView dgvVisitantes;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colEmpresa;
        private DataGridViewButtonColumn colSelecionarEntrada;
        private Label lblTotalVisitantes;
    }
}
