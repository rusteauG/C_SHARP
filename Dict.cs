//        // Step 1: Create a list to hold the first names
List<string> names = new();
// Step 2: Continuously ask for names until an empty string is entered
while (true)
{
    Console.Write("Please enter your first name (or press Enter to finish): ");
    string name = Console.ReadLine();

    // If the user enters an empty string, exit the loop
    if (string.IsNullOrEmpty(name))
    {
        break;
    }
    names.Add(name);
        }
// Step 3: Loop through the list and greet each name
foreach (string name in names)
{
    Console.WriteLine($"Hello {name}!");

}














//string data = "Tim,Sue,Bob,Jane";
//List<string> list =  data.Split(',').ToList();
//foreach(string fname in list)
//{
//    Console.WriteLine(fname);
//}








//// Step 1: Ask the user for a comma-separated list of first names
//Console.Write("Please enter a comma-separated list of first names (no spaces): ");
//string input = Console.ReadLine();

//// Step 2: Split the input string into an array of names
//string[] names = input.Split(',');

//foreach (string name in names)
//{
//    Console.Write($" {name} ");
//}


//List<decimal> charges = new();
//charges.Add(23.45M);
//charges.Add(12.45M);
//charges.Add(123M);

//decimal total = default;
//for(int i = 0; i < charges.Count; i++)
//{
//    total += charges[i];
//}
//Console.WriteLine($"Total Charges: {total}");




//// Step 1: Create a Dictionary to hold Employee IDs and Names
//Dictionary<int, string> employeeDirectory = new Dictionary<int, string>();

//// Step 2: Populate the Dictionary with some employee records
//employeeDirectory.Add(101, "Neville Kalebi");
//employeeDirectory.Add(102, "Lola Moore");
//employeeDirectory.Add(103, "Mora Smith");
//employeeDirectory.Add(104, "John Doe");

//// Step 3: Prompt the user for their Employee ID
//Console.Write("Please enter your Employee ID: ");
//if (int.TryParse(Console.ReadLine(), out int employeeId))
//    {
//    if (employeeDirectory.ContainsKey(employeeId))
//    {
//        Console.WriteLine($"Employee ID: {employeeId}, Name: {employeeDirectory[employeeId]}");

//    }
//    else
//    {
//        Console.WriteLine("Employee ID not found.");
//    }

//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a numeric Employee ID.");

//}