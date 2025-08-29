using BusinessErrorConsole.Attributes;

namespace BusinessErrorConsole;

public static class LoginErrors
{
    [Error("Para seguir com este resgate é necessário escolher uma conta válida")]
    public static object RESG001 = null!;
}
