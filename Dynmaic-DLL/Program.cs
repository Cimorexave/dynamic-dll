﻿using System.Reflection;

var input = String.Empty;
bool inputIsValid()
{
    try
    {
        string path = Path.GetFullPath(input ?? "");
        if (!File.Exists(path)) return false;
        return true;
    }
    catch
    {
        return false;
    }
}
while (!inputIsValid())
{
    Console.Write("Enter the address of the dll file: ");
    input = Console.ReadLine();
}
Console.WriteLine(input);
Assembly assembly = Assembly.LoadFile(path: input ?? "");
//Type type = assembly?.GetType("Monatsjournal.Monatsjournal")!;
Type type = assembly?.GetType("ImportClassLib.Monats")!;
//MethodInfo method = type?.GetMethod("SayHi")!;
//Console.WriteLine($"assembly: {assembly} class: {type} method: {method}");
//_ = method?.Invoke(null, null);
MethodInfo PrintMessage = type.GetMethod("PrintMessage")!;
PrintMessage?.Invoke(null, new object[] { "the argument that was passed in." });


Console.ReadLine();


