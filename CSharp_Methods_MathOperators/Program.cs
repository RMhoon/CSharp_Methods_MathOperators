using System;

namespace CSharp_Methods_MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1;
            int operand2;
            string operator1;
            int result;

            if (int.TryParse(GetInput("Enter the first operand"), out operand1))
            {
    
                if (int.TryParse(GetInput("Enter the second operand"), out operand2))
                {
                    operator1 = GetInput("Enter operator + or *");
                    if (operator1 == "*")
                        Console.WriteLine($"The product of {operand1} X {operand2} = {Multiply(operand1, operand2)}");
                    else if (operator1 == "+")
                        Console.WriteLine($"The sum of the {operand1} + {operand2} = {Add(operand1, operand2)}");
                    else
                        Console.WriteLine("Invalid Operator");
                }
                else
                    Console.WriteLine("Invalid operand2.");
            }
            else
                Console.WriteLine("Invalid operand1.");

        }

        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
       public static  int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
