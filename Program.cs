using System;

namespace Calculator
{
    class Program
    {
        /*
        This program will ask for two numbers. Each time it will validate the given
        input is a number. It will ask again until two numbers are provided.
        Next, it will ask which operation to perform, and accepts several inputs for
        addition, subtraction, multiplication, and division. It checks that a valid
        operation is chosen and asks until one is provided.
        Last, the program asks if the user wants to run it again with two more numbers.
        If the user does not, it will exit, otherwise it begins again with number prompts.
        */

        static void Main(string[] args)
        {
            var firstNumber = 0m;
            var secondNumber = 0m;
            var result = 0m;
            var unsupportedOperation = true;
            var finished = false;
            string input = "";

            Console.WriteLine("This program will add, subtract, multiply, or divide two numbers you will enter.");
            
            while (finished == false)
            {
                Console.WriteLine("Enter the first number: ");
                input = Console.ReadLine();
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

                while (unsupportedOperation != false)
                {
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
                                Console.WriteLine($"{firstNumber} added to {secondNumber} equals " + string.Format("{0:0.#####}", result) + ".\n");
                                unsupportedOperation = false;
                                break;
                            }
                        case "subtract":
                        case "-":
                        case "sub":
                        case "minus":
                            {
                                result = firstNumber - secondNumber;
                                Console.WriteLine($"{firstNumber} minus {secondNumber} equals " + string.Format("{0:0.#####}", result) + ".\n");
                                unsupportedOperation = false;
                                break;
                            }
                        case "multiply":
                        case "x":
                        case "*":
                        case "mult":
                        case "times":
                            {
                                result = firstNumber * secondNumber;
                                Console.WriteLine($"{firstNumber} multiplied by {secondNumber} equals " + string.Format("{0:0.#####}", result) + ".\n");
                                unsupportedOperation = false;
                                break;
                            }
                        case "divide":
                        case "\\":
                        case "/":
                        case "div":
                        case "\u00F7":
                            {
                                result = firstNumber / secondNumber;
                                Console.WriteLine($"{firstNumber} divided by {secondNumber} equals " + string.Format("{0:0.#####}", result) + ".\n");
                                unsupportedOperation = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("That's not a supported operation.");
                                break;
                            }
                    }
                }

                Console.WriteLine("Would you like to repeat the process? (Y/N)");
                input = Console.ReadLine();
                
                if (input.ToLower().StartsWith('n')) finished = true;
                else unsupportedOperation = true;
            } 
        }
    }
}
