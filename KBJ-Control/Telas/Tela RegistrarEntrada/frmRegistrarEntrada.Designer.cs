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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            lblBuscarVisitante = new Label();
            textBox1 = new TextBox();
            dgvVisitantes = new DataGridView();
            btnCadastrarNVisitante = new Button();
            lblPessoaSetor = new Label();
            txtPessoaSetorVisitado = new TextBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            cmbMotivo = new ComboBox();
            lblCategoria = new Label();
            btnCancelar = new Button();
            btnConfirmarEntrada = new Button();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(224, 224, 224);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(486, 46);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar entrada";
            lblTitulo.Click += label1_Click;
            // 
            // lblBuscarVisitante
            // 
            lblBuscarVisitante.AutoSize = true;
            lblBuscarVisitante.Location = new Point(12, 65);
            lblBuscarVisitante.Name = "lblBuscarVisitante";
            lblBuscarVisitante.Size = new Size(226, 15);
            lblBuscarVisitante.TabIndex = 1;
            lblBuscarVisitante.Text = "Buscar visitante por nome ou documento";
            lblBuscarVisitante.Click += lblBuscarVisitante_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dgvVisitantes
            // 
            dgvVisitantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisitantes.Location = new Point(12, 112);
            dgvVisitantes.Name = "dgvVisitantes";
            dgvVisitantes.Size = new Size(460, 50);
            dgvVisitantes.TabIndex = 3;
            // 
            // btnCadastrarNVisitante
            // 
            btnCadastrarNVisitante.Location = new Point(12, 177);
            btnCadastrarNVisitante.Name = "btnCadastrarNVisitante";
            btnCadastrarNVisitante.Size = new Size(156, 29);
            btnCadastrarNVisitante.TabIndex = 4;
            btnCadastrarNVisitante.Text = "Cadastrar novo visitante";
            btnCadastrarNVisitante.UseVisualStyleBackColor = true;
            // 
            // lblPessoaSetor
            // 
            lblPessoaSetor.AutoSize = true;
            lblPessoaSetor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPessoaSetor.Location = new Point(12, 209);
            lblPessoaSetor.Name = "lblPessoaSetor";
            lblPessoaSetor.Size = new Size(167, 15);
            lblPessoaSetor.TabIndex = 5;
            lblPessoaSetor.Text = "**Pessoa ou setor visitado ***";
            lblPessoaSetor.Click += lblPessoaSetor_Click;
            // 
            // txtPessoaSetorVisitado
            // 
            txtPessoaSetorVisitado.Location = new Point(12, 227);
            txtPessoaSetorVisitado.Name = "txtPessoaSetorVisitado";
            txtPessoaSetorVisitado.PlaceholderText = "Digite o nome da pessoa ou do setor";
            txtPessoaSetorVisitado.Size = new Size(451, 23);
            txtPessoaSetorVisitado.TabIndex = 6;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotivo.Location = new Point(12, 263);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(104, 15);
            lblMotivo.TabIndex = 7;
            lblMotivo.Text = "Observações (opcional)";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(12, 281);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Descreva o motivo, se desejar";
            txtMotivo.Size = new Size(451, 23);
            txtMotivo.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(90, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEntrada
            // 
            btnConfirmarEntrada.Location = new Point(250, 383);
            btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            btnConfirmarEntrada.Size = new Size(129, 32);
            btnConfirmarEntrada.TabIndex = 10;
            btnConfirmarEntrada.Text = "Confirmar Entrada";
            btnConfirmarEntrada.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(12, 315);
            lblCategoria.Text = "Motivo da visita *";
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.Location = new Point(12, 335);
            cmbMotivo.Size = new Size(451, 23);
            cmbMotivo.Items.AddRange(new object[] { "CLIENTES", "FORNECEDORES", "PRESTADOR DE SERVIÇO", "OUTROS" });
            ClientSize = new Size(484, 427);
            Controls.Add(lblCategoria);
            Controls.Add(cmbMotivo);
            Controls.Add(btnConfirmarEntrada);
            Controls.Add(btnCancelar);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(txtPessoaSetorVisitado);
            Controls.Add(lblPessoaSetor);
            Controls.Add(btnCadastrarNVisitante);
            Controls.Add(dgvVisitantes);
            Controls.Add(textBox1);
            Controls.Add(lblBuscarVisitante);
            Controls.Add(pnlTitulo);
            Name = "frmRegistrarEntrada";
            Text = "frmRegistrarEntrada";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Label lblBuscarVisitante;
        private TextBox textBox1;
        private DataGridView dgvVisitantes;
        private Button btnCadastrarNVisitante;
        private Label lblPessoaSetor;
        private TextBox txtPessoaSetorVisitado;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private ComboBox cmbMotivo;
        private Label lblCategoria;
        private Button btnCancelar;
        private Button btnConfirmarEntrada;
    }
}
