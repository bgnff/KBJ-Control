namespace KBJK_Control.Telas.Tela_RegistrarEntrada
{
    partial class frmRegistrarEntrada
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            btnFechar = new Button();
            lblTitulo = new Label();
            pnlCampoBusca = new KBJK_Control.Controles.CampoArredondado();
            textBox1 = new TextBox();
            pnlTabelaVisitantes = new KBJK_Control.Controles.TabelaArredondada();
            dgvVisitantes = new DataGridView();
            pnlBotaoCadastrar = new Panel();
            btnCadastrarNVisitante = new KBJK_Control.Controles.BotaoArredondado();
            pnlCampoEmpresa = new KBJK_Control.Controles.CampoArredondado();
            txtEmpresa = new TextBox();
            pnlCampoDestino = new KBJK_Control.Controles.CampoArredondado();
            txtPessoaSetorVisitado = new TextBox();
            pnlCampoCategoria = new KBJK_Control.Controles.CampoArredondado();
            pnlCampoObservacoes = new KBJK_Control.Controles.CampoArredondado();
            txtMotivo = new TextBox();
            pnlBotaoCancelar = new Panel();
            btnCancelar = new KBJK_Control.Controles.BotaoArredondado();
            pnlBotaoConfirmar = new Panel();
            btnConfirmarEntrada = new KBJK_Control.Controles.BotaoArredondado();
            lblBuscarVisitante = new Label();
            lblPessoaSetor = new Label();
            lblMotivo = new Label();
            cmbMotivo = new ComboBox();
            lblCategoria = new Label();
            lblEmpresa = new Label();
            pnlRodape = new Panel();
            lblAvisoAutomatico = new Label();
            pnlTitulo.SuspendLayout();
            pnlCampoBusca.SuspendLayout();
            pnlTabelaVisitantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).BeginInit();
            pnlBotaoCadastrar.SuspendLayout();
            pnlCampoEmpresa.SuspendLayout();
            pnlCampoDestino.SuspendLayout();
            pnlCampoCategoria.SuspendLayout();
            pnlCampoObservacoes.SuspendLayout();
            pnlBotaoCancelar.SuspendLayout();
            pnlBotaoConfirmar.SuspendLayout();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(20, 34, 55);
            pnlTitulo.Controls.Add(btnFechar);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(3, 4, 3, 4);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(820, 84);
            pnlTitulo.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackColor = Color.FromArgb(20, 34, 55);
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12F);
            btnFechar.ForeColor = Color.FromArgb(205, 214, 225);
            btnFechar.Location = new Point(756, 25);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(32, 32);
            btnFechar.TabIndex = 20;
            btnFechar.Text = "×";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(32, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar entrada";
            lblTitulo.Click += label1_Click;
            // 
            // pnlCampoBusca
            // 
            pnlCampoBusca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCampoBusca.BackColor = Color.White;
            pnlCampoBusca.Controls.Add(textBox1);
            pnlCampoBusca.Location = new Point(32, 136);
            pnlCampoBusca.Margin = new Padding(3, 4, 3, 4);
            pnlCampoBusca.Name = "pnlCampoBusca";
            pnlCampoBusca.Padding = new Padding(1);
            pnlCampoBusca.Raio = 8;
            pnlCampoBusca.Size = new Size(756, 40);
            pnlCampoBusca.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 10);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome ou documento";
            textBox1.Size = new Size(732, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pnlTabelaVisitantes
            // 
            pnlTabelaVisitantes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabelaVisitantes.BackColor = Color.White;
            pnlTabelaVisitantes.Controls.Add(dgvVisitantes);
            pnlTabelaVisitantes.Location = new Point(32, 194);
            pnlTabelaVisitantes.Margin = new Padding(3, 4, 3, 4);
            pnlTabelaVisitantes.Name = "pnlTabelaVisitantes";
            pnlTabelaVisitantes.Padding = new Padding(1);
            pnlTabelaVisitantes.Size = new Size(756, 118);
            pnlTabelaVisitantes.TabIndex = 3;
            // 
            // dgvVisitantes
            // 
            dgvVisitantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVisitantes.BackgroundColor = Color.White;
            dgvVisitantes.BorderStyle = BorderStyle.None;
            dgvVisitantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVisitantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVisitantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisitantes.ColumnHeadersHeight = 38;
            dgvVisitantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVisitantes.EnableHeadersVisualStyles = false;
            dgvVisitantes.GridColor = Color.FromArgb(222, 229, 237);
            dgvVisitantes.Location = new Point(0, 0);
            dgvVisitantes.Margin = new Padding(0);
            dgvVisitantes.Name = "dgvVisitantes";
            dgvVisitantes.RowHeadersVisible = false;
            dgvVisitantes.RowHeadersWidth = 51;
            dgvVisitantes.Size = new Size(754, 116);
            dgvVisitantes.TabIndex = 0;
            // 
            // pnlBotaoCadastrar
            // 
            pnlBotaoCadastrar.Controls.Add(btnCadastrarNVisitante);
            pnlBotaoCadastrar.Location = new Point(32, 330);
            pnlBotaoCadastrar.Margin = new Padding(3, 4, 3, 4);
            pnlBotaoCadastrar.Name = "pnlBotaoCadastrar";
            pnlBotaoCadastrar.Size = new Size(218, 40);
            pnlBotaoCadastrar.TabIndex = 4;
            // 
            // btnCadastrarNVisitante
            // 
            btnCadastrarNVisitante.BackColor = Color.White;
            btnCadastrarNVisitante.Dock = DockStyle.Fill;
            btnCadastrarNVisitante.FlatAppearance.BorderColor = Color.Black;
            btnCadastrarNVisitante.FlatStyle = FlatStyle.Flat;
            btnCadastrarNVisitante.ForeColor = Color.FromArgb(48, 55, 65);
            btnCadastrarNVisitante.Location = new Point(0, 0);
            btnCadastrarNVisitante.Margin = new Padding(0);
            btnCadastrarNVisitante.Name = "btnCadastrarNVisitante";
            btnCadastrarNVisitante.Raio = 10;
            btnCadastrarNVisitante.Size = new Size(218, 40);
            btnCadastrarNVisitante.TabIndex = 0;
            btnCadastrarNVisitante.Text = "Cadastrar novo visitante";
            btnCadastrarNVisitante.UseVisualStyleBackColor = false;
            // 
            // pnlCampoEmpresa
            // 
            pnlCampoEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCampoEmpresa.BackColor = Color.White;
            pnlCampoEmpresa.Controls.Add(txtEmpresa);
            pnlCampoEmpresa.Location = new Point(32, 422);
            pnlCampoEmpresa.Margin = new Padding(3, 4, 3, 4);
            pnlCampoEmpresa.Name = "pnlCampoEmpresa";
            pnlCampoEmpresa.Padding = new Padding(1);
            pnlCampoEmpresa.Raio = 8;
            pnlCampoEmpresa.Size = new Size(756, 40);
            pnlCampoEmpresa.TabIndex = 5;
            // 
            // txtEmpresa
            // 
            txtEmpresa.BorderStyle = BorderStyle.None;
            txtEmpresa.Dock = DockStyle.None;
            txtEmpresa.Location = new Point(12, 10);
            txtEmpresa.Margin = new Padding(0);
            txtEmpresa.MaxLength = 150;
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(732, 20);
            txtEmpresa.TabIndex = 0;
            // 
            // pnlCampoDestino
            // 
            pnlCampoDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCampoDestino.BackColor = Color.White;
            pnlCampoDestino.Controls.Add(txtPessoaSetorVisitado);
            pnlCampoDestino.Location = new Point(32, 504);
            pnlCampoDestino.Margin = new Padding(3, 4, 3, 4);
            pnlCampoDestino.Name = "pnlCampoDestino";
            pnlCampoDestino.Padding = new Padding(1);
            pnlCampoDestino.Raio = 8;
            pnlCampoDestino.Size = new Size(756, 40);
            pnlCampoDestino.TabIndex = 6;
            // 
            // txtPessoaSetorVisitado
            // 
            txtPessoaSetorVisitado.BorderStyle = BorderStyle.None;
            txtPessoaSetorVisitado.Dock = DockStyle.None;
            txtPessoaSetorVisitado.Location = new Point(12, 10);
            txtPessoaSetorVisitado.Margin = new Padding(0);
            txtPessoaSetorVisitado.Name = "txtPessoaSetorVisitado";
            txtPessoaSetorVisitado.PlaceholderText = "Digite o nome da pessoa ou do setor";
            txtPessoaSetorVisitado.Size = new Size(732, 20);
            txtPessoaSetorVisitado.TabIndex = 0;
            // 
            // pnlCampoObservacoes
            // 
            pnlCampoObservacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCampoObservacoes.BackColor = Color.White;
            pnlCampoObservacoes.Controls.Add(txtMotivo);
            pnlCampoObservacoes.Location = new Point(32, 668);
            pnlCampoObservacoes.Margin = new Padding(3, 4, 3, 4);
            pnlCampoObservacoes.Name = "pnlCampoObservacoes";
            pnlCampoObservacoes.Padding = new Padding(1);
            pnlCampoObservacoes.Raio = 8;
            pnlCampoObservacoes.Size = new Size(756, 40);
            pnlCampoObservacoes.TabIndex = 8;
            // 
            // txtMotivo
            // 
            txtMotivo.BorderStyle = BorderStyle.None;
            txtMotivo.Dock = DockStyle.None;
            txtMotivo.Location = new Point(12, 10);
            txtMotivo.Margin = new Padding(0);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Descreva o motivo, se desejar";
            txtMotivo.Size = new Size(732, 20);
            txtMotivo.TabIndex = 0;
            // 
            // pnlCampoCategoria
            // 
            pnlCampoCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCampoCategoria.BackColor = Color.White;
            pnlCampoCategoria.Controls.Add(cmbMotivo);
            pnlCampoCategoria.Location = new Point(32, 586);
            pnlCampoCategoria.Margin = new Padding(3, 4, 3, 4);
            pnlCampoCategoria.Name = "pnlCampoCategoria";
            pnlCampoCategoria.Padding = new Padding(1);
            pnlCampoCategoria.Raio = 8;
            pnlCampoCategoria.Size = new Size(756, 40);
            pnlCampoCategoria.TabIndex = 7;
            // 
            // pnlBotaoCancelar
            // 
            pnlBotaoCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlBotaoCancelar.Controls.Add(btnCancelar);
            pnlBotaoCancelar.Location = new Point(512, 26);
            pnlBotaoCancelar.Margin = new Padding(3, 4, 3, 4);
            pnlBotaoCancelar.Name = "pnlBotaoCancelar";
            pnlBotaoCancelar.Size = new Size(114, 40);
            pnlBotaoCancelar.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(212, 217, 223);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(0, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Raio = 10;
            btnCancelar.Size = new Size(114, 40);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pnlBotaoConfirmar
            // 
            pnlBotaoConfirmar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlBotaoConfirmar.Controls.Add(btnConfirmarEntrada);
            pnlBotaoConfirmar.Location = new Point(638, 26);
            pnlBotaoConfirmar.Margin = new Padding(3, 4, 3, 4);
            pnlBotaoConfirmar.Name = "pnlBotaoConfirmar";
            pnlBotaoConfirmar.Size = new Size(150, 40);
            pnlBotaoConfirmar.TabIndex = 2;
            // 
            // btnConfirmarEntrada
            // 
            btnConfirmarEntrada.BackColor = Color.FromArgb(232, 185, 63);
            btnConfirmarEntrada.Dock = DockStyle.Fill;
            btnConfirmarEntrada.FlatAppearance.BorderSize = 0;
            btnConfirmarEntrada.FlatStyle = FlatStyle.Flat;
            btnConfirmarEntrada.ForeColor = Color.Black;
            btnConfirmarEntrada.Location = new Point(0, 0);
            btnConfirmarEntrada.Margin = new Padding(0);
            btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            btnConfirmarEntrada.Raio = 10;
            btnConfirmarEntrada.Size = new Size(150, 40);
            btnConfirmarEntrada.TabIndex = 0;
            btnConfirmarEntrada.Text = "Confirmar entrada";
            btnConfirmarEntrada.UseVisualStyleBackColor = false;
            // 
            // lblBuscarVisitante
            // 
            lblBuscarVisitante.AutoSize = true;
            lblBuscarVisitante.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBuscarVisitante.ForeColor = Color.FromArgb(48, 55, 65);
            lblBuscarVisitante.Location = new Point(32, 110);
            lblBuscarVisitante.Name = "lblBuscarVisitante";
            lblBuscarVisitante.Size = new Size(290, 20);
            lblBuscarVisitante.TabIndex = 1;
            lblBuscarVisitante.Text = "Buscar visitante por nome ou documento";
            lblBuscarVisitante.Click += lblBuscarVisitante_Click;
            // 
            // lblPessoaSetor
            // 
            lblPessoaSetor.AutoSize = true;
            lblPessoaSetor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPessoaSetor.ForeColor = Color.FromArgb(48, 55, 65);
            lblPessoaSetor.Location = new Point(32, 478);
            lblPessoaSetor.Name = "lblPessoaSetor";
            lblPessoaSetor.Size = new Size(189, 20);
            lblPessoaSetor.TabIndex = 5;
            lblPessoaSetor.Text = "Pessoa ou setor visitado *";
            lblPessoaSetor.Click += lblPessoaSetor_Click;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotivo.ForeColor = Color.FromArgb(48, 55, 65);
            lblMotivo.Location = new Point(32, 642);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(173, 20);
            lblMotivo.TabIndex = 7;
            lblMotivo.Text = "Observações (opcional)";
            // 
            // cmbMotivo
            // 
            cmbMotivo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbMotivo.BackColor = Color.White;
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.FlatStyle = FlatStyle.Flat;
            cmbMotivo.Items.AddRange(new object[] { "CLIENTES", "FORNECEDORES", "PRESTADOR DE SERVIÇO", "OUTROS" });
            cmbMotivo.Location = new Point(8, 6);
            cmbMotivo.Margin = new Padding(3, 4, 3, 4);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(740, 28);
            cmbMotivo.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(48, 55, 65);
            lblCategoria.Location = new Point(32, 560);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(132, 20);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Motivo da visita *";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmpresa.ForeColor = Color.FromArgb(48, 55, 65);
            lblEmpresa.Location = new Point(32, 396);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(219, 20);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Empresa de origem (opcional)";
            // 
            // pnlRodape
            // 
            pnlRodape.BackColor = Color.FromArgb(247, 249, 252);
            pnlRodape.Controls.Add(lblAvisoAutomatico);
            pnlRodape.Controls.Add(pnlBotaoCancelar);
            pnlRodape.Controls.Add(pnlBotaoConfirmar);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 728);
            pnlRodape.Margin = new Padding(3, 4, 3, 4);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(820, 92);
            pnlRodape.TabIndex = 19;
            // 
            // lblAvisoAutomatico
            // 
            lblAvisoAutomatico.AutoSize = true;
            lblAvisoAutomatico.ForeColor = Color.FromArgb(93, 111, 135);
            lblAvisoAutomatico.Location = new Point(32, 36);
            lblAvisoAutomatico.Name = "lblAvisoAutomatico";
            lblAvisoAutomatico.Size = new Size(474, 20);
            lblAvisoAutomatico.TabIndex = 0;
            lblAvisoAutomatico.Text = "A entrada será registrada automaticamente com data e horário atuais.";
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(820, 820);
            Controls.Add(lblEmpresa);
            Controls.Add(pnlCampoEmpresa);
            Controls.Add(lblCategoria);
            Controls.Add(pnlCampoCategoria);
            Controls.Add(pnlRodape);
            Controls.Add(pnlCampoObservacoes);
            Controls.Add(lblMotivo);
            Controls.Add(pnlCampoDestino);
            Controls.Add(lblPessoaSetor);
            Controls.Add(pnlBotaoCadastrar);
            Controls.Add(pnlTabelaVisitantes);
            Controls.Add(pnlCampoBusca);
            Controls.Add(lblBuscarVisitante);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(760, 820);
            Name = "frmRegistrarEntrada";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar entrada";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlCampoBusca.ResumeLayout(false);
            pnlCampoBusca.PerformLayout();
            pnlTabelaVisitantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).EndInit();
            pnlBotaoCadastrar.ResumeLayout(false);
            pnlCampoEmpresa.ResumeLayout(false);
            pnlCampoEmpresa.PerformLayout();
            pnlCampoDestino.ResumeLayout(false);
            pnlCampoDestino.PerformLayout();
            pnlCampoCategoria.ResumeLayout(false);
            pnlCampoObservacoes.ResumeLayout(false);
            pnlCampoObservacoes.PerformLayout();
            pnlBotaoCancelar.ResumeLayout(false);
            pnlBotaoConfirmar.ResumeLayout(false);
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Label lblBuscarVisitante;
        private TextBox textBox1;
        private DataGridView dgvVisitantes;
        private KBJK_Control.Controles.BotaoArredondado btnCadastrarNVisitante;
        private Label lblPessoaSetor;
        private TextBox txtPessoaSetorVisitado;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private ComboBox cmbMotivo;
        private Label lblCategoria;
        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private KBJK_Control.Controles.BotaoArredondado btnCancelar;
        private KBJK_Control.Controles.BotaoArredondado btnConfirmarEntrada;
        private Button btnFechar;
        private Panel pnlRodape;
        private Label lblAvisoAutomatico;
        private KBJK_Control.Controles.CampoArredondado pnlCampoBusca;
        private KBJK_Control.Controles.TabelaArredondada pnlTabelaVisitantes;
        private Panel pnlBotaoCadastrar;
        private KBJK_Control.Controles.CampoArredondado pnlCampoEmpresa;
        private KBJK_Control.Controles.CampoArredondado pnlCampoDestino;
        private KBJK_Control.Controles.CampoArredondado pnlCampoCategoria;
        private KBJK_Control.Controles.CampoArredondado pnlCampoObservacoes;
        private Panel pnlBotaoCancelar;
        private Panel pnlBotaoConfirmar;
    }
}
