using System.Diagnostics;


Hello();

public static partial class Program
{
    private static readonly ActivitySource MyActivitySource = new ActivitySource("MyCompany.MyProduct.MyLibrary");

    public static void Hello()
    {
        using var activity = MyActivitySource.StartActivity("SayHello");
        Console.WriteLine("Hello, World!");
    }
}