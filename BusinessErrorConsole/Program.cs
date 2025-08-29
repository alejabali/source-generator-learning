using BusinessErrorConsole;
using System;

var provider = ErrorMessageProviderFactory.Create();

Console.WriteLine(provider.GetMessage("BIS001"));
Console.WriteLine(provider.GetMessage("BIS002"));
Console.WriteLine(provider.GetMessage("RESG001"));
Console.WriteLine(provider.GetMessage("RESG002"));
Console.WriteLine(provider.GetMessage("OUTROCODIGO"));
