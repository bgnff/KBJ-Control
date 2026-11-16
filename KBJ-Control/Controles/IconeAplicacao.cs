namespace KBJK_Control.Controles;

/// <summary>Fornece o ícone da marca para as janelas do aplicativo.</summary>
public static class IconeAplicacao
{
    public static Icon Criar()
    {
        string caminho = Path.Combine(AppContext.BaseDirectory, "Recursos", "KBJ_Control.ico");

        return File.Exists(caminho)
            ? new Icon(caminho)
            : (Icon)SystemIcons.Application.Clone();
    }
}
