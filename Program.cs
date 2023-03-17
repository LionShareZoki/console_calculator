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
            // Adition code
            Console.Write("Enter the first operand: ");
            string input1 = Console.ReadLine();
            double firstOperand;
            if (input1 == "mem")
            {
                firstOperand = memAddSub;
            }
            else
            {
                firstOperand = double.Parse(input1);
            }

            Console.Write("Enter the second operand: ");
            string input2 = Console.ReadLine();
            double secondOperand;
            if (input2 == "mem")
            {
                secondOperand = memAddSub;
            }
            else
            {
                secondOperand = double.Parse(input2);
            }

            double result = firstOperand + secondOperand;
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits((decimal)result)[3])[2];
            
            if (decimalPlaces > 5)
            {
                result = Math.Round(result, 5);
            }
            Console.WriteLine($"Result: {result:#,0.#####}");


            memAddSub = result;
            memMulDiv = result;
        }
        else if (input == "2")
        {
            // Subtraction code
            Console.Write("Enter the first operand: ");
            string input1 = Console.ReadLine();
            double firstOperand;
            if (input1 == "mem")
            {
                firstOperand = memAddSub;
            }
            else
            {
                firstOperand = double.Parse(input1);
            }

            Console.Write("Enter the second operand: ");
            string input2 = Console.ReadLine();
            double secondOperand;
            if (input2 == "mem")
            {
                secondOperand = memAddSub;
            }
            else
            {
                secondOperand = double.Parse(input2);
            }

            double result = firstOperand - secondOperand;
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits((decimal)result)[3])[2];

            if (decimalPlaces > 5)
            {
                result = Math.Round(result, 5);
            }
            Console.WriteLine($"Result: {result:#,0.#####}");
            memAddSub = result;
            memMulDiv = result;

        }
        else if (input == "3")
        {
            // Multiplication code
            Console.Write("Enter the first operand: ");
            string input1 = Console.ReadLine();
            double firstOperand;
            if (input1 == "mem")
            {
                firstOperand = memMulDiv;
            }
            else
            {
                firstOperand = double.Parse(input1);
            }

            Console.Write("Enter the second operand: ");
            string input2 = Console.ReadLine();
            double secondOperand;
            if (input2 == "mem")
            {
                secondOperand = memMulDiv;
            }
            else
            {
                secondOperand = double.Parse(input2);
            }

            double result = firstOperand * secondOperand;
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits((decimal)result)[3])[2];

            if (decimalPlaces > 5)
            {
                result = Math.Round(result, 5);
            }
            Console.WriteLine($"Result: {result:#,0.#####}");
            memAddSub = result;
            memMulDiv = result;
        }
        else if (input == "4")
        {
            // Division code
            Console.Write("Enter the first operand: ");
            string input1 = Console.ReadLine();
            double firstOperand;
            if (input1 == "mem")
            {
                firstOperand = memMulDiv;
            }
            else
            {
                firstOperand = double.Parse(input1);
            }

            Console.Write("Enter the second operand: ");
            string input2 = Console.ReadLine();
            double secondOperand;
            if (input2 == "mem")
            {
                secondOperand = memMulDiv;
            }
            else
            {
                secondOperand = double.Parse(input2);
            }

            double result = firstOperand / secondOperand;
            int decimalPlaces = BitConverter.GetBytes(decimal.GetBits((decimal)result)[3])[2];

            if (decimalPlaces > 5)
            {
                result = Math.Round(result, 5);
            }
            Console.WriteLine($"Result: {result:#,0.#####}");
            memAddSub = result;
            memMulDiv = result;
        }
        else if (input == "5")
        {
            memAddSub = 0;
            memMulDiv = 1;
            Console.WriteLine("Memory clear");
        }
        else if (input == "6")
        {
            
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}