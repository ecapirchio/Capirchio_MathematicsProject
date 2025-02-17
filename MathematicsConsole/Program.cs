using System;
using Capirchio_Mathematics;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            /*foreach(var a in args)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine(); */

            AreArgumentsValid(args);

            var basicMath = new BasicMath();
            var advMath = new AdvMath();

            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {basicMath.AddNumbers(_num1, _num2)}");
                    break;

                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {basicMath.SubtractNumbers(_num1, _num2)}");
                    break;

                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {basicMath.MultiplyNumbers(_num1, _num2)}");
                    break;

                case "div":
                    if (_num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine($"{_num1} / {_num2} = {basicMath.DivideNumbers(_num1, _num2)}");
                    }
                    break;

                case "area":
                    Console.WriteLine($"Area (Height: {_num1}, Width: {_num2}): {advMath.CalculateArea(_num1, _num2)}");
                    break;

                case "average":
                    var numbers = args.Skip(2).Select(arg => NumParser(arg)).ToList();
                    Console.WriteLine($"Average: {advMath.CalculateAverage(numbers)}");
                    break;

                case "square":
                    Console.WriteLine($"Square of {_num1}: {advMath.CalculateSquared(_num1)}");
                    break;

                case "hypotenuse":
                    Console.WriteLine($"Hypotenuse (Sides: {_num1}, {_num2}): {advMath.CalculateHypotenuse(_num1, _num2)}");
                    break;

                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter Add, Sub, Mul, Div, Area, Average, Square, or Hypotenuse");
                    break;
            }
            Console.ReadLine();
        }

        public static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();
            _num1 = NumParser(args[2]);
            _num2 = NumParser(args[3]);
            Console.WriteLine("All Arguments are valid!");
            //Console.ReadLine();
        }

        public static double NumParser(string arg)
        {
            double number;
            if (Double.TryParse(arg, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
            }
            return 0;
        }
    }
}

