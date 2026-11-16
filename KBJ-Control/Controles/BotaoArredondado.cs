using System.Drawing.Drawing2D;

namespace KBJK_Control.Controles;

public class BotaoArredondado : Button
{
    private readonly System.Windows.Forms.Timer _temporizadorHover = new() { Interval = 15 };
    private Color _corNormal;
    private Color _corInicial;
    private Color _corDestino;
    private int _passoHover;

    public int Raio { get; set; } = 10;

    public BotaoArredondado()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        UseVisualStyleBackColor = false;
        BackColor = Color.FromArgb(232, 185, 63);
        ForeColor = Color.Black;
        Padding = Padding.Empty;

        _temporizadorHover.Tick += (_, _) =>
        {
            if (IsDisposed || Disposing)
            {
                _temporizadorHover.Stop();
                return;
            }

            _passoHover = Math.Min(_passoHover + 1, 10);
            BackColor = Misturar(_corInicial, _corDestino, _passoHover / 10f);
            if (_passoHover == 10)
                _temporizadorHover.Stop();
        };
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        _corNormal = BackColor;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        AnimarPara(Misturar(_corNormal, Color.White, 0.10f));
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        AnimarPara(_corNormal);
    }

    protected override void OnMouseDown(MouseEventArgs mevent)
    {
        base.OnMouseDown(mevent);
        AnimarPara(Misturar(_corNormal, Color.Black, 0.10f));
    }

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
        base.OnMouseUp(mevent);
        AnimarPara(ClientRectangle.Contains(PointToClient(Cursor.Position)) ? Misturar(_corNormal, Color.White, 0.10f) : _corNormal);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            _temporizadorHover.Dispose();
        base.Dispose(disposing);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        AtualizarRecorte();
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // O fundo retangular nativo do Button cria cantos aparentes.
        // O preenchimento abaixo desenha somente a área arredondada.
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using var caminho = CriarCaminho(ClientRectangle);

        using var fundo = new SolidBrush(BackColor);
        e.Graphics.FillPath(fundo, caminho);

        if (FlatAppearance.BorderSize > 0)
        {
            using var borda = new Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize);
            e.Graphics.DrawPath(borda, caminho);
        }

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            ClientRectangle,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private void AtualizarRecorte()
    {
        if (Width < 2 || Height < 2)
            return;

        using var caminho = CriarCaminho(ClientRectangle);
        Region = new Region(caminho);
    }

    private GraphicsPath CriarCaminho(Rectangle area)
    {
        var caminho = new GraphicsPath();
        var limite = Rectangle.Inflate(area, -1, -1);
        int diametro = Math.Min(Math.Max(2, Raio * 2), Math.Min(limite.Width, limite.Height));

        caminho.AddArc(limite.Left, limite.Top, diametro, diametro, 180, 90);
        caminho.AddArc(limite.Right - diametro, limite.Top, diametro, diametro, 270, 90);
        caminho.AddArc(limite.Right - diametro, limite.Bottom - diametro, diametro, diametro, 0, 90);
        caminho.AddArc(limite.Left, limite.Bottom - diametro, diametro, diametro, 90, 90);
        caminho.CloseFigure();
        return caminho;
    }

    private void AnimarPara(Color destino)
    {
        if (IsDisposed || Disposing)
            return;

        _corInicial = BackColor;
        _corDestino = destino;
        _passoHover = 0;
        _temporizadorHover.Start();
    }

    private static Color Misturar(Color origem, Color destino, float progresso) => Color.FromArgb(
        (int)(origem.R + (destino.R - origem.R) * progresso),
        (int)(origem.G + (destino.G - origem.G) * progresso),
        (int)(origem.B + (destino.B - origem.B) * progresso));
}
