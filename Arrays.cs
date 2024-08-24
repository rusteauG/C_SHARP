//Split() -string to array using a delimeter
//string.Join(" sep ",the array)  method in C# is used to concatenate the elements of a collection (such as an array or a list) into a single string, with a specified separator between each element


// Define an array of delimiters
string sentence = "Hello World;This Is:CSharp"; 
char[] delimiters = new char[] { ' ', ';', ':' };
Console.WriteLine(delimiters);
foreach (char delimiter in delimiters)
{
    Console.WriteLine($"'{delimiter}'");
}
Console.WriteLine(string.Join(",", delimiters));

string[] words = sentence.Split(delimiters);// implicitly converts the char[] to a string
foreach (string word in words)
{
    Console.WriteLine(word);
}


int[] arr = new int[4] { 1, 10, 20, 20 };//Other Arrays (int[], double[], etc.): The ToString() method is called on the array, which outputs the type name instead of the contents.
Console.WriteLine(arr);//System.Int32[]

Console.WriteLine(string.Join(' ', arr));


for (int i = 0; i < arr.Length; i++)
{

    Console.WriteLine(arr[i]);
}

foreach (char a in arr) { Console.WriteLine(a); }

string[] lastNames = new string[] { "John", "Smith", "Jones", "Neville" };
Console.WriteLine(lastNames); //System.String


//ways to initialize an array
//1. Using the Array.Empty<T>() method:
string[] lNames = Array.Empty<string>();//This creates an empty array of strings.

Console.WriteLine(lNames);//System.String

//2. Using the new keyword with dimensions:
string[] fNames = new string[4];
//This creates an array of strings with four elements, but the elements are initially null. You can then assign values to the elements individually.

//3
int[] numbers = { 1,2,3,4,5};
Console.WriteLine(string.Join(' ',numbers));

/*You can't directly use Join() on an array of integers. Join() is a method of the string class, which operates on strings. However, you can convert the integers to strings and then join them.
 */
