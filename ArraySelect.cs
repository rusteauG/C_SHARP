int numberOfNames = GetValidNumNames("How many names you want to enter: ");

string[] names = new string[numberOfNames];

for(int i=0; i<numberOfNames; i++)
{
    Console.Write($"Enter Name:{i+1}: ");
    names[i] = Console.ReadLine().Trim().ToLower();
    Console.WriteLine();
}

Console.WriteLine($"Which names you want to Select,Enter Number 1 to {names.Length}");
string input = Console.ReadLine();

//Validate inpute
if(int.TryParse(input, out  int selectedIndex) && selectedIndex>=1 && selectedIndex <=names.Length)
{
    //Process the selected name
    Console.WriteLine($"You selected: {names[selectedIndex-1]}");
}
else
{
    Console.WriteLine($"Invalid input. Please enter a number between 1 and {names.Length}.");

}

int GetValidNumNames(string prompt)
{
    int numberOfNames = default;
    bool isValid;
    do
    {
        Console.Write(prompt);
        isValid = int.TryParse(Console.ReadLine(),out numberOfNames );
        if ( !isValid || numberOfNames <=0)
        {
            Console.WriteLine("Please enter a valid positive number.");

        }
    } while (!isValid || numberOfNames <=0);
    return numberOfNames;
}