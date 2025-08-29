using BusinessErrorShared.Attributes;

namespace BusinessErrorConsole.Errors;

public static class BoletoInvestimentoErrors
{
    [Error("Bloqueio de Instituição Financeira não encontrado")]
    public static readonly object BIS001 = null!;

    [Error("Para seguir com este investimento é necessário dar \"aceite\" no termo de desenquadramento.")]
    public static readonly object BIS002 = null!;
}
