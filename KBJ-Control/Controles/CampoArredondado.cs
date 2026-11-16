using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KBJK_Control.Controles
{
    [ToolboxItem(true)]
    public class CampoArredondado : Panel
    {
        public int Raio { get; set; } = 8;

        public CampoArredondado()
        {
            BackColor = Color.White;
            Padding = new Padding(1);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle area = new(0, 0, Width - 1, Height - 1);
            int diametro = Raio * 2;

            using GraphicsPath caminho = new();
            caminho.AddArc(area.Left, area.Top, diametro, diametro, 180, 90);
            caminho.AddArc(area.Right - diametro, area.Top, diametro, diametro, 270, 90);
            caminho.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            caminho.AddArc(area.Left, area.Bottom - diametro, diametro, diametro, 90, 90);
            caminho.CloseFigure();

            using Pen borda = new(Color.FromArgb(218, 225, 234));
            e.Graphics.DrawPath(borda, caminho);
        }
    }
}