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
            lblSub = new System.Windows.Forms.Label();
            pnlTitulo = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            lblNomeVisitante = new System.Windows.Forms.Label();
            txtNomeCompleto = new System.Windows.Forms.TextBox();
            lblTipoDocumento = new System.Windows.Forms.Label();
            cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            lblNumeroDocumento = new System.Windows.Forms.Label();
            txtNumeroDocumento = new System.Windows.Forms.TextBox();
            lblEmpresaOrigem = new System.Windows.Forms.Label();
            txtEmpresaOrigem = new System.Windows.Forms.TextBox();
            lblPbaixo = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnRealizarCadastro = new System.Windows.Forms.Button();
            pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            lblSub.Location = new System.Drawing.Point(12, 54);
            lblSub.Name = "lblSub";
            lblSub.Size = new System.Drawing.Size(361, 15);
            lblSub.TabIndex = 0;
            lblSub.Text = "Preencha os dados do visitante. Os campos com * são obrigatórios.";
            lblSub.Click += this.label1_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pnlTitulo.BackColor = System.Drawing.Color.FromArgb((System.Int32)(System.Byte)224, (System.Int32)(System.Byte)224, (System.Int32)(System.Byte)224);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Location = new System.Drawing.Point(1, 1);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new System.Drawing.Size(484, 50);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (System.Byte)0);
            lblTitulo.Location = new System.Drawing.Point(3, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(135, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Novo Visitante";
            // 
            // lblNomeVisitante
            // 
            lblNomeVisitante.AutoSize = true;
            lblNomeVisitante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (System.Byte)0);
            lblNomeVisitante.Location = new System.Drawing.Point(12, 89);
            lblNomeVisitante.Name = "lblNomeVisitante";
            lblNomeVisitante.Size = new System.Drawing.Size(105, 15);
            lblNomeVisitante.TabIndex = 1;
            lblNomeVisitante.Text = "Nome completo *";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new System.Drawing.Point(12, 107);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.PlaceholderText = "Digite o nome completo:";
            txtNomeCompleto.Size = new System.Drawing.Size(449, 23);
            txtNomeCompleto.TabIndex = 2;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (System.Byte)0);
            lblTipoDocumento.Location = new System.Drawing.Point(12, 149);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new System.Drawing.Size(120, 15);
            lblTipoDocumento.TabIndex = 3;
            lblTipoDocumento.Text = "Tipo de documento*";
            lblTipoDocumento.Click += this.lblTipoDocumento_Click;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new System.Drawing.Point(12, 167);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new System.Drawing.Size(150, 23);
            cmbTipoDocumento.TabIndex = 4;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (System.Byte)0);
            lblNumeroDocumento.Location = new System.Drawing.Point(184, 149);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new System.Drawing.Size(145, 15);
            lblNumeroDocumento.TabIndex = 5;
            lblNumeroDocumento.Text = "Número do documento *";
            lblNumeroDocumento.UseWaitCursor = true;
            lblNumeroDocumento.Click += this.lblNumeroDocumento_Click;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new System.Drawing.Point(184, 167);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.PlaceholderText = "Digite o numero do documento:";
            txtNumeroDocumento.Size = new System.Drawing.Size(277, 23);
            txtNumeroDocumento.TabIndex = 6;
            // 
            // lblEmpresaOrigem
            // 
            lblEmpresaOrigem.AutoSize = true;
            lblEmpresaOrigem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (System.Byte)0);
            lblEmpresaOrigem.Location = new System.Drawing.Point(12, 202);
            lblEmpresaOrigem.Name = "lblEmpresaOrigem";
            lblEmpresaOrigem.Size = new System.Drawing.Size(171, 15);
            lblEmpresaOrigem.TabIndex = 7;
            lblEmpresaOrigem.Text = "Empresa de origem (opcional)";
            // 
            // txtEmpresaOrigem
            // 
            txtEmpresaOrigem.Location = new System.Drawing.Point(12, 220);
            txtEmpresaOrigem.Name = "txtEmpresaOrigem";
            txtEmpresaOrigem.PlaceholderText = "Digite o nome da empresa de origem:";
            txtEmpresaOrigem.Size = new System.Drawing.Size(277, 23);
            txtEmpresaOrigem.TabIndex = 8;
            txtEmpresaOrigem.TextChanged += this.txtEmpresaOrigem_TextChanged;
            // 
            // lblPbaixo
            // 
            lblPbaixo.AutoSize = true;
            lblPbaixo.ForeColor = System.Drawing.Color.Silver;
            lblPbaixo.Location = new System.Drawing.Point(2, 255);
            lblPbaixo.Name = "lblPbaixo";
            lblPbaixo.Size = new System.Drawing.Size(470, 15);
            lblPbaixo.TabIndex = 9;
            lblPbaixo.Text = "Ao salvar ou selecionar um cadastro, o visitante ficará selecionado em Registrar entrada.";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(51, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(160, 38);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRealizarCadastro
            // 
            btnRealizarCadastro.Location = new System.Drawing.Point(250, 300);
            btnRealizarCadastro.Name = "btnRealizarCadastro";
            btnRealizarCadastro.Size = new System.Drawing.Size(160, 38);
            btnRealizarCadastro.TabIndex = 11;
            btnRealizarCadastro.Text = "Realizar Cadastro";
            btnRealizarCadastro.UseVisualStyleBackColor = true;
            btnRealizarCadastro.Click += this.button2_Click;
            // 
            // FrmCadastrarVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(btnRealizarCadastro);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(lblPbaixo);
            this.Controls.Add(txtEmpresaOrigem);
            this.Controls.Add(lblEmpresaOrigem);
            this.Controls.Add(txtNumeroDocumento);
            this.Controls.Add(lblNumeroDocumento);
            this.Controls.Add(cmbTipoDocumento);
            this.Controls.Add(lblTipoDocumento);
            this.Controls.Add(txtNomeCompleto);
            this.Controls.Add(lblNomeVisitante);
            this.Controls.Add(pnlTitulo);
            this.Controls.Add(lblSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarVisitante";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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