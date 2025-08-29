using BusinessErrorShared.Attributes;

namespace BusinessErrorConsole.Errors;

public static class BoletoResgateErrors
{
    [Error("Resgate não permitida por esse canal")]
    public static readonly object RESG001 = null!;

    [Error("Resgate - Data inválida")]
    public static readonly object RESG002 = null!;
}
