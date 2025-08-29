using System;

namespace BusinessErrorConsole
{
    public class BusinessException : Exception
    {
        public string ErrorCode { get; }

        public BusinessException(string errorCode) : base(ErrorMessageProviderFactory.Create().GetMessage(errorCode))
        {
            ErrorCode = errorCode;
        }
    }
}
