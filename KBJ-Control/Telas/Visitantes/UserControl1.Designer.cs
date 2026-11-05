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
            tlpVisitantes = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpVisitantes
            // 
            tlpVisitantes.ColumnCount = 2;
            tlpVisitantes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVisitantes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVisitantes.Dock = DockStyle.Fill;
            tlpVisitantes.Location = new Point(0, 0);
            tlpVisitantes.Name = "tlpVisitantes";
            tlpVisitantes.RowCount = 4;
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpVisitantes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpVisitantes.Size = new Size(1100, 650);
            tlpVisitantes.TabIndex = 0;
            // 
            // ucVisitantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpVisitantes);
            Name = "ucVisitantes";
            Size = new Size(1100, 650);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpVisitantes;
    }
}
