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
            lblSub = new Label();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            lblNomeVisitante = new Label();
            txtNomeCompleto = new TextBox();
            lblTipoDocumento = new Label();
            cmbTipoDocumento = new ComboBox();
            lblNumeroDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            lblEmpresaOrigem = new Label();
            txtEmpresaOrigem = new TextBox();
            lblPbaixo = new Label();
            btnCancelar = new Button();
            btnRealizarCadastro = new Button();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.ForeColor = SystemColors.AppWorkspace;
            lblSub.Location = new Point(12, 54);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(361, 15);
            lblSub.TabIndex = 0;
            lblSub.Text = "Preencha os dados do visitante. Os campos com * são obrigatórios.";
            lblSub.Click += label1_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.Top;
            pnlTitulo.BackColor = Color.FromArgb(224, 224, 224);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Location = new Point(1, 1);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(484, 50);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(3, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(135, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo Visitante";
            // 
            // lblNomeVisitante
            // 
            lblNomeVisitante.AutoSize = true;
            lblNomeVisitante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeVisitante.Location = new Point(12, 89);
            lblNomeVisitante.Name = "lblNomeVisitante";
            lblNomeVisitante.Size = new Size(105, 15);
            lblNomeVisitante.TabIndex = 1;
            lblNomeVisitante.Text = "Nome completo *";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(12, 107);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.PlaceholderText = "Digite o nome completo:";
            txtNomeCompleto.Size = new Size(449, 23);
            txtNomeCompleto.TabIndex = 2;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDocumento.Location = new Point(12, 149);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(120, 15);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo de documento*";
            lblTipoDocumento.Click += lblTipoDocumento_Click;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(12, 167);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(150, 23);
            cmbTipoDocumento.TabIndex = 4;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroDocumento.Location = new Point(184, 149);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(145, 15);
            lblNumeroDocumento.TabIndex = 5;
            lblNumeroDocumento.Text = "Número do documento *";
            lblNumeroDocumento.UseWaitCursor = true;
            lblNumeroDocumento.Click += lblNumeroDocumento_Click;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(184, 167);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.PlaceholderText = "Digite o numero do documento:";
            txtNumeroDocumento.Size = new Size(277, 23);
            txtNumeroDocumento.TabIndex = 6;
            // 
            // lblEmpresaOrigem
            // 
            lblEmpresaOrigem.AutoSize = true;
            lblEmpresaOrigem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpresaOrigem.Location = new Point(12, 202);
            lblEmpresaOrigem.Name = "lblEmpresaOrigem";
            lblEmpresaOrigem.Size = new Size(171, 15);
            lblEmpresaOrigem.TabIndex = 7;
            lblEmpresaOrigem.Text = "Empresa de origem (opcional)";
            // 
            // txtEmpresaOrigem
            // 
            txtEmpresaOrigem.Location = new Point(12, 220);
            txtEmpresaOrigem.Name = "txtEmpresaOrigem";
            txtEmpresaOrigem.PlaceholderText = "Digite o nome da empresa de origem:";
            txtEmpresaOrigem.Size = new Size(277, 23);
            txtEmpresaOrigem.TabIndex = 8;
            txtEmpresaOrigem.TextChanged += txtEmpresaOrigem_TextChanged;
            // 
            // lblPbaixo
            // 
            lblPbaixo.AutoSize = true;
            lblPbaixo.ForeColor = Color.Silver;
            lblPbaixo.Location = new Point(2, 255);
            lblPbaixo.Name = "lblPbaixo";
            lblPbaixo.Size = new Size(470, 15);
            lblPbaixo.TabIndex = 9;
            lblPbaixo.Text = "Ao salvar ou selecionar um cadastro, o visitante ficará selecionado em Registrar entrada.";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(51, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 38);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRealizarCadastro
            // 
            btnRealizarCadastro.Location = new Point(250, 300);
            btnRealizarCadastro.Name = "btnRealizarCadastro";
            btnRealizarCadastro.Size = new Size(160, 38);
            btnRealizarCadastro.TabIndex = 11;
            btnRealizarCadastro.Text = "Realizar Cadastro";
            btnRealizarCadastro.UseVisualStyleBackColor = true;
            btnRealizarCadastro.Click += button2_Click;
            // 
            // FrmCadastrarVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnRealizarCadastro);
            Controls.Add(btnCancelar);
            Controls.Add(lblPbaixo);
            Controls.Add(txtEmpresaOrigem);
            Controls.Add(lblEmpresaOrigem);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeVisitante);
            Controls.Add(pnlTitulo);
            Controls.Add(lblSub);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCadastrarVisitante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarVisitante";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSub;
        private Panel pnlTitulo;
        private Label lblTitulo;
        private Label lblNomeVisitante;
        private TextBox txtNomeCompleto;
        private Label lblTipoDocumento;
        private ComboBox cmbTipoDocumento;
        private Label lblNumeroDocumento;
        private TextBox txtNumeroDocumento;
        private Label lblEmpresaOrigem;
        private TextBox txtEmpresaOrigem;
        private Label lblPbaixo;
        private Button btnCancelar;
        private Button btnRealizarCadastro;
    }
}