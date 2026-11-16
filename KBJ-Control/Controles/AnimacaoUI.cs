using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace KBJK_Control.Controles;

/// <summary>
/// Animações leves para a interface WinForms. Não depende de bibliotecas
/// externas e não altera os controles configurados no Designer.
/// </summary>
public static class AnimacaoUI
{
    private sealed class EstadoBotao
    {
        public Color CorNormal = Color.Empty;
        public Color CorInicial = Color.Empty;
        public Color CorDestino = Color.Empty;
        public int Passo;
        public readonly System.Windows.Forms.Timer Temporizador = new() { Interval = 15 };
    }

    private static readonly ConditionalWeakTable<Button, EstadoBotao> Estados = new();

    public static void AplicarHoverBotoes(Control raiz)
    {
        foreach (Control controle in raiz.Controls)
        {
            if (controle is Button botao && controle is not BotaoArredondado)
                AplicarHover(botao);

            if (controle.HasChildren)
                AplicarHoverBotoes(controle);
        }
    }

    public static void AplicarHover(Button botao)
    {
        if (Estados.TryGetValue(botao, out _))
            return;

        var estado = new EstadoBotao { CorNormal = botao.BackColor };
        Estados.Add(botao, estado);

        estado.Temporizador.Tick += (_, _) =>
        {
            if (botao.IsDisposed || botao.Disposing)
            {
                estado.Temporizador.Stop();
                return;
            }

            estado.Passo = Math.Min(estado.Passo + 1, 10);
            float progresso = estado.Passo / 10f;
            botao.BackColor = Misturar(estado.CorInicial, estado.CorDestino, progresso);

            if (estado.Passo == 10)
                estado.Temporizador.Stop();
        };

        botao.MouseEnter += (_, _) =>
        {
            if (botao.IsDisposed || botao.Disposing)
                return;

            // Captura a cor já configurada pelo formulário ou pelo Designer.
            estado.CorNormal = botao.BackColor;
            AnimarCor(botao, estado, Clarear(estado.CorNormal, 0.10f));
        };
        botao.MouseLeave += (_, _) =>
        {
            if (!botao.IsDisposed && !botao.Disposing)
                AnimarCor(botao, estado, estado.CorNormal);
        };
        botao.MouseDown += (_, _) =>
        {
            if (!botao.IsDisposed && !botao.Disposing)
                AnimarCor(botao, estado, Escurecer(estado.CorNormal, 0.10f));
        };
        botao.MouseUp += (_, _) =>
        {
            if (botao.IsDisposed || botao.Disposing)
                return;

            bool mouseSobreBotao = botao.ClientRectangle.Contains(botao.PointToClient(Cursor.Position));
            AnimarCor(botao, estado, mouseSobreBotao ? Clarear(estado.CorNormal, 0.10f) : estado.CorNormal);
        };
        botao.Disposed += (_, _) => estado.Temporizador.Dispose();
    }

    public static void AnimarAbertura(Form formulario, int deslocamento = 14)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            return;

        formulario.Shown += (_, _) =>
        {
            Point origem = formulario.Location;
            int origemY = origem.Y;
            formulario.Opacity = 0;
            if (formulario.WindowState == FormWindowState.Normal)
                formulario.Location = new Point(origem.X, origemY + deslocamento);

            var temporizador = new System.Windows.Forms.Timer { Interval = 15 };
            int passo = 0;
            temporizador.Tick += (_, _) =>
            {
                passo = Math.Min(passo + 1, 12);
                float progresso = passo / 12f;
                float suave = 1f - MathF.Pow(1f - progresso, 3);
                formulario.Opacity = suave;

                if (formulario.WindowState == FormWindowState.Normal)
                    formulario.Location = new Point(origem.X, origemY + (int)(deslocamento * (1f - suave)));

                if (passo == 12)
                {
                    formulario.Opacity = 1;
                    formulario.Location = origem;
                    temporizador.Stop();
                    temporizador.Dispose();
                }
            };
            temporizador.Start();
        };
    }

    public static void DeslizarEntrada(Control controle, Control recipiente, int deslocamento = 12)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime || recipiente.ClientSize.Height == 0)
        {
            controle.Dock = DockStyle.Fill;
            return;
        }

        controle.Dock = DockStyle.None;
        controle.Bounds = new Rectangle(0, deslocamento, recipiente.ClientSize.Width, recipiente.ClientSize.Height);
        controle.BringToFront();

        var temporizador = new System.Windows.Forms.Timer { Interval = 15 };
        int passo = 0;
        temporizador.Tick += (_, _) =>
        {
            if (controle.IsDisposed || controle.Disposing || recipiente.IsDisposed || recipiente.Disposing)
            {
                temporizador.Stop();
                temporizador.Dispose();
                return;
            }

            passo = Math.Min(passo + 1, 18);
            float progresso = 1f - MathF.Pow(1f - passo / 18f, 3);
            controle.Top = (int)(deslocamento * (1f - progresso));

            if (passo == 18)
            {
                controle.Dock = DockStyle.Fill;
                temporizador.Stop();
                temporizador.Dispose();
            }
        };
        temporizador.Start();
    }

    private static void AnimarCor(Button botao, EstadoBotao estado, Color destino)
    {
        if (botao.IsDisposed || botao.Disposing)
            return;

        estado.CorInicial = botao.BackColor;
        estado.CorDestino = destino;
        estado.Passo = 0;
        estado.Temporizador.Start();
    }

    private static Color Clarear(Color cor, float intensidade) => Misturar(cor, Color.White, intensidade);
    private static Color Escurecer(Color cor, float intensidade) => Misturar(cor, Color.Black, intensidade);

    private static Color Misturar(Color origem, Color destino, float progresso) => Color.FromArgb(
        (int)(origem.R + (destino.R - origem.R) * progresso),
        (int)(origem.G + (destino.G - origem.G) * progresso),
        (int)(origem.B + (destino.B - origem.B) * progresso));
}
