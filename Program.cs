using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 0m;
            var secondNumber = 0m;
            var result = 0m;

            Console.WriteLine("This program will add, subtract, multiply, or divide two numbers you will enter.");
            Console.WriteLine("Enter the first number: ");
            string input = Console.ReadLine();
            while (!(Decimal.TryParse(input, out firstNumber)))
            {
                Console.WriteLine("Input needs to be an integer or decimal\nEnter the first number: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter the second number: ");
            input = Console.ReadLine();
            while (!(Decimal.TryParse(input, out secondNumber)))
            {
                Console.WriteLine("Input needs to be an integer or var\nEnter the second number: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Type one of the following and press enter - add, subtract, multiply, divide: ");
            input = Console.ReadLine();
            input.ToLower();
            switch (input)
            {
                case "add":
                case "+":
                case "plus":
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} added to {secondNumber} equals " + string.Format("{0:.#####}", result) + ".");
                        break;
                    }
                case "subtract":
                case "-":
                case "sub":
                case "minus":
                    {
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} minus {secondNumber} equals " + string.Format("{0:.#####}", result) + ".");
                        break;
                    }
                case "multiply":
                case "x":
                case "*":
                case "mult":
                case "times":
                    {
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} multiplied by {secondNumber} equals " + string.Format("{0:.#####}", result) + ".");
                        break;
                    }
                case "divide":
                case "\\":
                case "/":
                case "div":
                case "\u00F7":
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} divided by {secondNumber} equals " + string.Format("{0:.#####}", result) + ".");
                        break;
                    }
                default:
                    {
                        //TODO: Get this to loop instead of exiting.
                        Console.WriteLine("No operation was chosen. Exiting.");
                        break;
                    }

            }
        }

        /*
         ***Project objectives***
        Create a console application
        Manage a git repository containing a C# console application
        Demonstrate 'branch' workflow

        ***Project requirement***    
        -Make a minimum of six commits. - Done
        -Include a .gitignore file that removes the .suo from source control - Done
        -Follow csharp code conventions - Done
        -Follow the four outlined steps above. You may choose to do more, 
        like ask for three numbers if you finish the project quickly
        -Implement a form of branching, i.e. if/else or switch statement
        -Validate user input and catch an exception. i.e. if you request a number
        from the user, and they instead type out a word like writing "four," request 
        they resubmit or exit the program gracefully." You may want to review 
        training on exception handling and reach out to the class for additional 
        exception handling information. We will discuss exception handling more next week.
        -Try to think of additional exception you may catch that could arise from your code.
        -You may demonstrate objected oriented programming through making additional classes.
        Additional classes are not a requirement this week.

        The steps for your console application should include:
        -Ask the user for the first number
        -Ask the user for the second number
        -Ask the user if they would like to add, subtract, multiply, or divide
        -Return the result
         */

    }
    
}
