//can hold diff data types
using System.Collections;

ArrayList list = new ArrayList();
list.Add(5);
list.Add("Hello");
list.Add(true);

// loop through elements in an ArrayList 
foreach (object i in list)
{
    Console.WriteLine(i);
}

//Using a for loop:
for (int i = 0; i < list.Count; i++)
{
    object item = list[i];
    Console.WriteLine(item);
}
int num =(int) list[0];
Console.WriteLine(num)