
Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoise = Console.ReadLine();

if(userChoise == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye(); 
}

PrintHello();
PrintGoodBye();




static void PrintHello() // function / Method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}

