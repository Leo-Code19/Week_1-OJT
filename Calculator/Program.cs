using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            var first_num = Console.ReadLine();
            float convert_First_num = Convert.ToSingle(first_num);

            Console.Write("Enter Second Number: ");
            var second_num = Console.ReadLine();
            float convert_Second_num = Convert.ToSingle(second_num);

            Console.Write("Enter Operator(+, -, /, *): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    float result_ADD = convert_First_num + convert_Second_num;
                    Console.WriteLine("Result: " + result_ADD);
                    break;

                case "-":
                    float result_SUB = convert_First_num - convert_Second_num;
                    Console.WriteLine("Result: " + result_SUB);
                    break;

                case "*":
                    float result_MUL = convert_First_num * convert_Second_num;
                    Console.WriteLine("Result: " + result_MUL);
                    break;

                case "/":
                    float result_DIV = convert_First_num / convert_Second_num;
                    Console.WriteLine("Result: " + result_DIV);
                    break;

                default:
                    Console.WriteLine("Error operator input. Try Again");
                    break;
            }
        }
    }
}
