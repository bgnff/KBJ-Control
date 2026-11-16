using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KBJK_Control.Controles
{
    /// <summary>
    /// Aplica cantos arredondados ao contêiner da tabela sem interferir na pintura interna do DataGridView.
    /// </summary>
    public sealed class TabelaArredondada : Panel
    {
        private const int Raio = 12;

        public TabelaArredondada()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            Padding = new Padding(1);
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0) return;

            using GraphicsPath caminho = CriarCaminho(ClientRectangle, Raio);
            Region = new Region(caminho);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0) return;

            using GraphicsPath caminho = CriarCaminho(new Rectangle(0, 0, Width - 1, Height - 1), Raio);
            using Pen borda = new Pen(Color.FromArgb(218, 225, 234));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(borda, caminho);
        }

        private static GraphicsPath CriarCaminho(Rectangle area, int raio)
        {
            int diametro = raio * 2;
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddArc(area.Left, area.Top, diametro, diametro, 180, 90);
            caminho.AddArc(area.Right - diametro, area.Top, diametro, diametro, 270, 90);
            caminho.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            caminho.AddArc(area.Left, area.Bottom - diametro, diametro, diametro, 90, 90);
            caminho.CloseFigure();
            return caminho;
        }
    }

    internal static class EstiloTabela
    {
        public static void Aplicar(DataGridView tabela)
        {
            if (tabela.Parent is TabelaArredondada || tabela.Parent is null) return;

            Control pai = tabela.Parent;
            int indice = pai.Controls.GetChildIndex(tabela);
            TableLayoutPanel? layout = pai as TableLayoutPanel;
            TableLayoutPanelCellPosition posicao = layout?.GetPositionFromControl(tabela) ?? default;
            TabelaArredondada recipiente = new TabelaArredondada
            {
                Name = $"{tabela.Name}Arredondada",
                Dock = tabela.Dock,
                Anchor = tabela.Anchor,
                Margin = tabela.Margin,
                TabIndex = tabela.TabIndex,
                Bounds = tabela.Bounds
            };

            pai.SuspendLayout();
            pai.Controls.Remove(tabela);
            if (layout is not null)
                layout.Controls.Add(recipiente, posicao.Column, posicao.Row);
            else
                pai.Controls.Add(recipiente);

            pai.Controls.SetChildIndex(recipiente, indice);
            tabela.Dock = DockStyle.Fill;
            tabela.Margin = Padding.Empty;
            recipiente.Controls.Add(tabela);
            pai.ResumeLayout(true);
        }

        public static void AplicarCampo(Control campo) => Envolver(campo, 1);

        public static void AplicarBotao(Button botao)
        {
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.UseVisualStyleBackColor = false;
            Envolver(botao, 0);
        }

        private static void Envolver(Control controle, int espacamento)
        {
            if (controle.Parent is TabelaArredondada || controle.Parent is null) return;

            Control pai = controle.Parent;
            int indice = pai.Controls.GetChildIndex(controle);
            TableLayoutPanel? layout = pai as TableLayoutPanel;
            TableLayoutPanelCellPosition posicao = layout?.GetPositionFromControl(controle) ?? default;
            TabelaArredondada recipiente = new TabelaArredondada
            {
                Name = $"{controle.Name}Arredondado",
                Dock = controle.Dock,
                Anchor = controle.Anchor,
                Margin = controle.Margin,
                TabIndex = controle.TabIndex,
                Bounds = controle.Bounds,
                BackColor = controle.BackColor,
                Padding = new Padding(espacamento)
            };

            pai.SuspendLayout();
            pai.Controls.Remove(controle);
            if (layout is not null)
                layout.Controls.Add(recipiente, posicao.Column, posicao.Row);
            else
                pai.Controls.Add(recipiente);

            pai.Controls.SetChildIndex(recipiente, indice);
            controle.Dock = DockStyle.Fill;
            controle.Margin = Padding.Empty;
            if (controle is TextBox texto) texto.BorderStyle = BorderStyle.None;
            if (controle is ComboBox lista) lista.FlatStyle = FlatStyle.Flat;
            recipiente.Controls.Add(controle);
            pai.ResumeLayout(true);
        }
    }
}
