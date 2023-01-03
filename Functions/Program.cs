Console.WriteLine("Are you coming or leaving?(in/out):");
string userChois = Console.ReadLine();

if (userChois == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}






    static void PrintHello()
{
    Console.WriteLine("hello world");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}