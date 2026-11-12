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
            pnlcima.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlcima
            // 
            pnlcima.BackColor = Color.FromArgb(224, 224, 224);
            pnlcima.Controls.Add(lblTitulo);
            pnlcima.Location = new Point(0, -1);
            pnlcima.Name = "pnlcima";
            pnlcima.Size = new Size(484, 48);
            pnlcima.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(12, 9);
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
            lblNomeCadastro1.Location = new Point(30, 87);
            lblNomeCadastro1.Name = "lblNomeCadastro1";
            lblNomeCadastro1.Size = new Size(46, 15);
            lblNomeCadastro1.TabIndex = 3;
            lblNomeCadastro1.Text = "Nome*";
            lblNomeCadastro1.Click += lblNomeCadastro1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(30, 104);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite o nome do visitante:";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 4;
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSobrenome.Location = new Point(277, 87);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(77, 15);
            lblSobrenome.TabIndex = 5;
            lblSobrenome.Text = "Sobrenome*";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(277, 105);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.PlaceholderText = "Digite o sobrenome do visitante:";
            txtSobrenome.Size = new Size(159, 23);
            txtSobrenome.TabIndex = 6;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDocumento.Location = new Point(12, 184);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(120, 15);
            lblTipoDocumento.TabIndex = 7;
            lblTipoDocumento.Text = "Tipo do documento*";
            // 
            // cbxTipoDocumento
            // 
            cbxTipoDocumento.FormattingEnabled = true;
            cbxTipoDocumento.Location = new Point(12, 202);
            cbxTipoDocumento.Name = "cbxTipoDocumento";
            cbxTipoDocumento.Size = new Size(121, 23);
            cbxTipoDocumento.TabIndex = 8;
            // 
            // lblNdocumento
            // 
            lblNdocumento.AutoSize = true;
            lblNdocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNdocumento.Location = new Point(178, 184);
            lblNdocumento.Name = "lblNdocumento";
            lblNdocumento.Size = new Size(142, 15);
            lblNdocumento.TabIndex = 9;
            lblNdocumento.Text = "Numero do documento*";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmissor.Location = new Point(351, 184);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(79, 15);
            lblEmissor.TabIndex = 10;
            lblEmissor.Text = "País emissor*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 11;
            // 
            // cbxEmissor
            // 
            cbxEmissor.FormattingEnabled = true;
            cbxEmissor.Location = new Point(351, 202);
            cbxEmissor.Name = "cbxEmissor";
            cbxEmissor.Size = new Size(121, 23);
            cbxEmissor.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnSalvarCadastro);
            panel1.Controls.Add(btnCancelar);
            panel1.Location = new Point(0, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 47);
            panel1.TabIndex = 13;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = SystemColors.AppWorkspace;
            lblDesc.Location = new Point(0, 246);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(474, 15);
            lblDesc.TabIndex = 14;
            lblDesc.Text = "A empresa será informada ao registrar a entrada. Ao salvar, o visitante ficará selecionado.";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(224, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 32);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadastro
            // 
            btnSalvarCadastro.Location = new Point(355, 3);
            btnSalvarCadastro.Name = "btnSalvarCadastro";
            btnSalvarCadastro.Size = new Size(117, 32);
            btnSalvarCadastro.TabIndex = 16;
            btnSalvarCadastro.Text = "Salvar Cadastro";
            btnSalvarCadastro.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrarVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(lblDesc);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCadastrarVisitante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarVisitante";
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
    }
}