namespace KBJK_Control.Telas.Dashboard
{
    partial class FrmCadastrarVisitante
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
            pnlcima = new Panel();
            lblTitulo = new Label();
            lblNomeCadastro = new Label();
            lblNomeCadastro1 = new Label();
            txtNome = new TextBox();
            lblSobrenome = new Label();
            txtSobrenome = new TextBox();
            lblTipoDocumento = new Label();
            cbxTipoDocumento = new ComboBox();
            lblNdocumento = new Label();
            lblEmissor = new Label();
            textBox1 = new TextBox();
            cbxEmissor = new ComboBox();
            panel1 = new Panel();
            lblDesc = new Label();
            btnCancelar = new Button();
            btnSalvarCadastro = new Button();
            btnFechar = new Button();
            lblInstrucao = new Label();
            lblAjudaNome = new Label();
            lblAjudaSobrenome = new Label();
            lblAjudaDocumento = new Label();
            lblAjudaPais = new Label();
            pnlcima.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlcima
            // 
            pnlcima.BackColor = Color.FromArgb(20, 34, 55);
            pnlcima.Controls.Add(lblTitulo);
            pnlcima.Controls.Add(btnFechar);
            pnlcima.Location = new Point(0, 0);
            pnlcima.Name = "pnlcima";
            pnlcima.Size = new Size(720, 80);
            pnlcima.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(32, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Novo Visitante";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblNomeCadastro
            // 
            lblNomeCadastro.AutoSize = true;
            lblNomeCadastro.Location = new Point(12, 107);
            lblNomeCadastro.Name = "lblNomeCadastro";
            lblNomeCadastro.Size = new Size(0, 15);
            lblNomeCadastro.TabIndex = 2;
            // 
            // lblNomeCadastro1
            // 
            lblNomeCadastro1.AutoSize = true;
            lblNomeCadastro1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeCadastro1.ForeColor = Color.FromArgb(48, 55, 65);
            lblNomeCadastro1.Location = new Point(32, 120);
            lblNomeCadastro1.Name = "lblNomeCadastro1";
            lblNomeCadastro1.Size = new Size(46, 15);
            lblNomeCadastro1.TabIndex = 3;
            lblNomeCadastro1.Text = "Nome *";
            lblNomeCadastro1.Click += lblNomeCadastro1_Click;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(32, 142);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o nome";
            txtNome.Size = new Size(300, 27);
            txtNome.TabIndex = 4;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSobrenome.ForeColor = Color.FromArgb(48, 55, 65);
            lblSobrenome.Location = new Point(376, 120);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(77, 15);
            lblSobrenome.TabIndex = 5;
            lblSobrenome.Text = "Sobrenome *";
            // 
            // txtSobrenome
            // 
            txtSobrenome.BorderStyle = BorderStyle.FixedSingle;
            txtSobrenome.Location = new Point(376, 142);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.PlaceholderText = "Digite o sobrenome";
            txtSobrenome.Size = new Size(312, 27);
            txtSobrenome.TabIndex = 6;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDocumento.ForeColor = Color.FromArgb(48, 55, 65);
            lblTipoDocumento.Location = new Point(32, 212);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(120, 15);
            lblTipoDocumento.TabIndex = 7;
            lblTipoDocumento.Text = "Tipo de documento *";
            // 
            // cbxTipoDocumento
            // 
            cbxTipoDocumento.FormattingEnabled = true;
            cbxTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoDocumento.Location = new Point(32, 234);
            cbxTipoDocumento.Name = "cbxTipoDocumento";
            cbxTipoDocumento.Size = new Size(180, 28);
            cbxTipoDocumento.TabIndex = 8;
            // 
            // lblNdocumento
            // 
            lblNdocumento.AutoSize = true;
            lblNdocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNdocumento.ForeColor = Color.FromArgb(48, 55, 65);
            lblNdocumento.Location = new Point(242, 212);
            lblNdocumento.Name = "lblNdocumento";
            lblNdocumento.Size = new Size(142, 15);
            lblNdocumento.TabIndex = 9;
            lblNdocumento.Text = "Número do documento *";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmissor.ForeColor = Color.FromArgb(48, 55, 65);
            lblEmissor.Location = new Point(506, 212);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(79, 15);
            lblEmissor.TabIndex = 10;
            lblEmissor.Text = "País emissor *";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(242, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 11;
            // 
            // cbxEmissor
            // 
            cbxEmissor.FormattingEnabled = true;
            cbxEmissor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmissor.Location = new Point(506, 234);
            cbxEmissor.Name = "cbxEmissor";
            cbxEmissor.Size = new Size(182, 28);
            cbxEmissor.TabIndex = 12;
            // 
            // btnFechar
            //
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.FromArgb(90, 105, 124);
            btnFechar.Location = new Point(670, 22);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(28, 28);
            btnFechar.TabIndex = 17;
            btnFechar.Text = "×";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // lblInstrucao
            //
            lblInstrucao.AutoSize = true;
            lblInstrucao.ForeColor = Color.FromArgb(93, 108, 126);
            lblInstrucao.Location = new Point(32, 94);
            lblInstrucao.Name = "lblInstrucao";
            lblInstrucao.Size = new Size(406, 15);
            lblInstrucao.TabIndex = 18;
            lblInstrucao.Text = "Preencha os dados do visitante. Os campos com * são obrigatórios.";
            // 
            // lblAjudaNome
            //
            lblAjudaNome.AutoSize = true;
            lblAjudaNome.ForeColor = Color.FromArgb(110, 123, 140);
            lblAjudaNome.Location = new Point(32, 174);
            lblAjudaNome.Name = "lblAjudaNome";
            lblAjudaNome.Size = new Size(93, 15);
            lblAjudaNome.TabIndex = 19;
            lblAjudaNome.Text = "Máx. 30 caracteres";
            // 
            // lblAjudaSobrenome
            //
            lblAjudaSobrenome.AutoSize = true;
            lblAjudaSobrenome.ForeColor = Color.FromArgb(110, 123, 140);
            lblAjudaSobrenome.Location = new Point(376, 174);
            lblAjudaSobrenome.Name = "lblAjudaSobrenome";
            lblAjudaSobrenome.Size = new Size(93, 15);
            lblAjudaSobrenome.TabIndex = 20;
            lblAjudaSobrenome.Text = "Máx. 30 caracteres";
            // 
            // lblAjudaDocumento
            //
            lblAjudaDocumento.AutoSize = true;
            lblAjudaDocumento.ForeColor = Color.FromArgb(110, 123, 140);
            lblAjudaDocumento.Location = new Point(242, 266);
            lblAjudaDocumento.Name = "lblAjudaDocumento";
            lblAjudaDocumento.Size = new Size(93, 15);
            lblAjudaDocumento.TabIndex = 21;
            lblAjudaDocumento.Text = "Máx. 20 caracteres";
            // 
            // lblAjudaPais
            //
            lblAjudaPais.AutoSize = true;
            lblAjudaPais.ForeColor = Color.FromArgb(110, 123, 140);
            lblAjudaPais.Location = new Point(506, 266);
            lblAjudaPais.Name = "lblAjudaPais";
            lblAjudaPais.Size = new Size(126, 15);
            lblAjudaPais.TabIndex = 22;
            lblAjudaPais.Text = "País emissor do documento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 248, 251);
            panel1.Controls.Add(btnSalvarCadastro);
            panel1.Controls.Add(btnCancelar);
            panel1.Location = new Point(0, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 72);
            panel1.TabIndex = 13;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = SystemColors.AppWorkspace;
            lblDesc.ForeColor = Color.FromArgb(101, 112, 124);
            lblDesc.Location = new Point(32, 294);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(474, 15);
            lblDesc.TabIndex = 14;
            lblDesc.Text = "A empresa será informada ao registrar a entrada. Ao salvar, o visitante ficará selecionado.";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(212, 217, 223);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(448, 18);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 36);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadastro
            // 
            btnSalvarCadastro.Location = new Point(576, 18);
            btnSalvarCadastro.BackColor = Color.FromArgb(232, 185, 63);
            btnSalvarCadastro.FlatStyle = FlatStyle.Flat;
            btnSalvarCadastro.FlatAppearance.BorderSize = 0;
            btnSalvarCadastro.Name = "btnSalvarCadastro";
            btnSalvarCadastro.Size = new Size(112, 36);
            btnSalvarCadastro.TabIndex = 16;
            btnSalvarCadastro.Text = "Salvar Cadastro";
            btnSalvarCadastro.UseVisualStyleBackColor = false;
            // 
            // FrmCadastrarVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(720, 420);
            Controls.Add(lblDesc);
            Controls.Add(lblAjudaPais);
            Controls.Add(lblAjudaDocumento);
            Controls.Add(lblAjudaSobrenome);
            Controls.Add(lblAjudaNome);
            Controls.Add(lblInstrucao);
            Controls.Add(panel1);
            Controls.Add(cbxEmissor);
            Controls.Add(textBox1);
            Controls.Add(lblEmissor);
            Controls.Add(lblNdocumento);
            Controls.Add(cbxTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblNomeCadastro1);
            Controls.Add(lblNomeCadastro);
            Controls.Add(pnlcima);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmCadastrarVisitante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KBJ Control - Novo visitante";
            pnlcima.ResumeLayout(false);
            pnlcima.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlcima;
        private Label lblTitulo;
        private Label lblNomeCadastro;
        private Label lblNomeCadastro1;
        private TextBox txtNome;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private Label lblTipoDocumento;
        private ComboBox cbxTipoDocumento;
        private Label lblNdocumento;
        private Label lblEmissor;
        private TextBox textBox1;
        private ComboBox cbxEmissor;
        private Panel panel1;
        private Button btnSalvarCadastro;
        private Button btnCancelar;
        private Label lblDesc;
        private Button btnFechar;
        private Label lblInstrucao;
        private Label lblAjudaNome;
        private Label lblAjudaSobrenome;
        private Label lblAjudaDocumento;
        private Label lblAjudaPais;
    }
}
