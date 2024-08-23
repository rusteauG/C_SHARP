Console.Write("What is your First Name: ");
string firstName = Console.ReadLine();
Console.Write("What is your age: ");
string ageText = Console.ReadLine();

string formattedString;
if (int.TryParse(ageText, out int age) == false)
{
    Console.WriteLine("You did not provide a valid age");
    return;
}

// Check if the age is non-negative
if (age < 0)
{
    Console.WriteLine("Age cannot be negative. Please enter a valid age.");
    return;
}

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formattedString = $"Professor {firstName}";
}
else
{
    formattedString = firstName;
}

if (age < 21)
{
    Console.WriteLine($"Recoomend you wait {21 - age} years, {formattedString}");
}
else
{
    Console.WriteLine($"Welcome to class {formattedString}");
}