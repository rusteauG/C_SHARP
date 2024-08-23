GetValidItemCode();
string name = GetName("Enter Item name: ");
double price = GetValidDouble("Enter Price");
int qty = GetValidInt("Enter quantity:");

double amount = qty * price;
double dis = (amount * 5) / 100;
double net = amount - dis;

PrintBill(icode, name, price, qty, amount, dis, net);

Console.ReadKey();


//method to GetName
string GetName(string prompt)
{
    Console.Write(prompt);
    do
    {
      string  itemName = Console.ReadLine();

        if (String.IsNullOrEmpty(itemName))
        {
            Console.WriteLine("Name Cannot be EMpty , Try Again!: ");

        }
    } while (string.IsNullOrEmpty(itemName));

    return name;
}


//method to print bill
void PrintBill(int icode, string name, double price, int qty, double amount, double dis, double net)
{
    Console.WriteLine("----ABC Super Market----");
    Console.WriteLine($"Item code: {icode}");
    Console.WriteLine($"Item Name: {name}");
    Console.WriteLine($"Item Price: {price}");
    Console.WriteLine($"Quantity: {qty}");
    Console.WriteLine($"Amount: {amount}");
    Console.WriteLine($"Discount 5%: {dis}");
    Console.WriteLine($"Net Bill Amount Rs.: {net}");
}




//Method to get valid qty
int GetValidInt(string message)
{
    int value = default;
    bool isValid;
    do
    {
        Console.Write(message);
        isValid = int.TryParse(Console.ReadLine(), out value);


        if (!isValid)
        {
            Console.WriteLine("Please enter a valid number.");

        }


    } while (!isValid);
    return value;
}


// Method to get a valid double value
double GetValidDouble(string meassage)
{
    double value = default;
    bool isValid;

    do
    {
        Console.Write(meassage);
        isValid = double.TryParse(Console.ReadLine(), out value);
        if (!isValid)
        {
            Console.WriteLine("Please enter a valid number.");

        }
    } while (!isValid);

    return value;
}


// Method to validate item code and return it
int GetValidItemCode()
{
    int code = default;
    bool isValidCode;
    do
    {
        Console.WriteLine("Enter item code:");
        isValidCode = int.TryParse(Console.ReadLine(), out code);
        if (!isValidCode)
        {
            Console.WriteLine("Please enter a valid numeric code.");

        }
    } while (!isValidCode);
    return code;
}
