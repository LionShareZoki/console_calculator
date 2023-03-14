
{
    while (true)
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Clear memory");
        Console.WriteLine("6. Exit");

        Console.Write("Enter your choice: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("odabra si jedinicu");
        }
        else if (input == "2")
        {
            // Code for Subtraction
        }
        else if (input == "3")
        {
            // Code for Multiplication
        }
        else if (input == "4")
        {
            // Code for Division
        }
        else if (input == "5")
        {
            // Code for Clear memory
        }
        else if (input == "6")
        {
            // Code for Exit
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadLine(); // Wait for user input before closing the console window
}
