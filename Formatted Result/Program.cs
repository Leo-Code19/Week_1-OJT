using System;

class Program
{
    static void Main()
    {
        // 1. Ask for user name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // 2. Ask for product prize
        Console.Write("Enter the product price: ");
        string priceInput = Console.ReadLine();

        // Convert the text input into a decimal number
        decimal price = Convert.ToDecimal(priceInput);

        // 3. Display the formatted result
        Console.WriteLine("\n--- Receipt ---");
        Console.WriteLine($"Customer Name:\t{name}");
        Console.WriteLine($"Total Price:\t{price}");
    }
}
