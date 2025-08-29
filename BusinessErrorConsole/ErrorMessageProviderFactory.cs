using BusinessErrorShared;
using BusinessErrorShared.Interfaces;
using System;

namespace BusinessErrorConsole
{
    public static class ErrorMessageProviderFactory
    {
        public static IErrorMessageProvider Create()
        {
            var providerType = Type.GetType("BusinessErrorGenerator.GeneratedErrorMessageProvider");

            if (providerType == null)
                return new DefaultErrorMessageProvider();

            return Activator.CreateInstance(providerType) as IErrorMessageProvider ?? new DefaultErrorMessageProvider();
        }
    }
}
