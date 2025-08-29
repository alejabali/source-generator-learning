using BusinessErrorShared.Interfaces;

namespace BusinessErrorShared
{
    public class DefaultErrorMessageProvider : IErrorMessageProvider
    {
        public string GetMessage(string errorCode)
        {
            return $"Não foi possível buscar o erro {errorCode}, pois, nenhum arquivo de erro foi gerado";
        }
    }
}
