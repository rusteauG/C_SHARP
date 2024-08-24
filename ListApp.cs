string data = "Corey,Smith,Jones";
string[] arrData = data.Split(',');
foreach (string item in arrData)
{
    Console.WriteLine(item);
}

//make a list instead
List<string> list = data.Split(',').ToList();
list.Add("neville");
list.Sort();
foreach (string item in list) { Console.WriteLine(item); }




List<int> numbers = new List<int> { 1, 2, 3 };
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
numbers.Add(8);
numbers.Add(9);
numbers.Add(10);
List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
foreach (int x in evenNumbers)
{
    Console.WriteLine(x);  //2 4 6 8 10
}
int mindex = evenNumbers.FindIndex(x => x > 5);//Gets the index of the first element that matches a specified predicate.
Console.WriteLine(mindex); //index 2   --6


List<string> fruits = new List<string>();
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("orange");

fruits.AddRange(new string[] { "mango", "peach", "grapes" });

fruits.Insert(1, "Kiwi");

fruits.InsertRange(0, new string[] { "Tomato", "dragonfruit", "Pomato" });


fruits.Remove("apple");

int ind = fruits.IndexOf("peach"); //starting from index 0
Console.WriteLine($"Peach at index:{ind}");


//fruits.RemoveAt(0);

//fruits.Clear();  Clear(): Removes all elements from the list.

int fruitsCount = fruits.Count;
Console.WriteLine($"Count: {fruitsCount}");


foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine($"Get fruit at index: 1 - {fruitsCount}");
if (int.TryParse(Console.ReadLine(), out int index) && ind >= 1 && ind <= fruitsCount)
{

    string selFruit = fruits.ElementAt(ind - 1);
    Console.WriteLine($"You selected: {selFruit} at index {ind}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and {fruitsCount}.");
}




Console.Write("Check the list for: ");
string searchFruits = Console.ReadLine();
if (fruits.Contains(searchFruits.Trim().ToLower())) // bool
{
    Console.WriteLine($"we have {searchFruits} in the list");
}