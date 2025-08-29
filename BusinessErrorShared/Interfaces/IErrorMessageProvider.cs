namespace BusinessErrorShared.Interfaces
{
    public interface IErrorMessageProvider
    {
        string GetMessage(string errorCode);
    }
}
