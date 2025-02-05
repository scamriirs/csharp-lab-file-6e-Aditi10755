using System;

class Example
{
    public static string StaticMessage;

    public string InstanceMessage;

    static Example()
    {
        StaticMessage = "Static constructor initialized this message.";
        Console.WriteLine("Static constructor called.");
    }

    public Example(string message)
    {
        InstanceMessage = message;
        Console.WriteLine("Instance constructor called.");
    }

    public void DisplayMessages()
    {
        Console.WriteLine($"Static Message: {StaticMessage}");
        Console.WriteLine($"Instance Message: {InstanceMessage}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program started.");

        Console.WriteLine($"Static Message (Before instance creation): {Example.StaticMessage}");

        Example obj = new Example("This is an instance message.");

        obj.DisplayMessages();

        Console.WriteLine("Program ended.");
    }
}
