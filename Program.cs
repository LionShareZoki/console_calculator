{

    double memAddSub = 0;
    double memMulDiv = 1;

    Console.WriteLine("Main Menu:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Clear memory");
    Console.WriteLine("6. Exit");

    Console.Write("Enter your choice: ");
    while (true)
    {
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.Write("Enter the first operand: ");
            double firstOperand = double.Parse(Console.ReadLine());

            Console.Write("Enter the second operand: ");
            double secondOperand = double.Parse(Console.ReadLine());

            double result = firstOperand + secondOperand + memAddSub;
            Console.WriteLine($"Result: {result}");

            memAddSub = result;
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
}