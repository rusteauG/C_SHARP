//Eg_3 Loops
RunApplication();

static void RunApplication()
{
    while (true)
    {
        string name = GetName();
        if (name .ToLower() == "exit")
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            break;
        }
        WelcomeUser(name);
    }
}

static string GetName()
{
    Console.Write("Please enter your name (or type 'exit' to quit): ");
    return Console.ReadLine();
}
static void  WelcomeUser(string name)
{
    
    if(name.Trim().ToLower() == "neville")
    {
        Console.WriteLine($"Welcome Professor {name}");
    }
    else
    {
        Console.WriteLine($"Welcome to the class, {name}!");

    }
}