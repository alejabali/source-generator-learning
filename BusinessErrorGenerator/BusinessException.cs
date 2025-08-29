using System;

namespace BusinessErrorGenerator
{
    public class BusinessException : Exception
    {
        public string ErrorCode { get; }

        public BusinessException(string errorCode) : base(GetMessage(errorCode))
        {
            ErrorCode = errorCode;
        }

        private static string GetMessage(string errorCode)
        {
#if BUSINESSERRORS_GENERATED
            return BusinessErrors.GetMessage(errorCode);
#else
            return $"Erro desconhecido: {errorCode}";
#endif
        }
    }
}
