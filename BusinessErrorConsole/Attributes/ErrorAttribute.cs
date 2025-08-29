using System;

namespace BusinessErrorConsole.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class ErrorAttribute : Attribute
{
    public string Message { get; }

    public ErrorAttribute(string message)
    {
        Message = message;
    }
}