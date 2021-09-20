using System;

namespace InterfaceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Functions func = new Functions();
            Console.WriteLine("Enter first number:");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int input2 = Int32.Parse(Console.ReadLine());

            int input1add = func.add(input1, input2);
            int input1min = func.min(input1, input2);
            int input1times = func.times(input1, input2);
            int input1div = func.div(input1, input2);

            Console.WriteLine("Addition of both numbers: " + input1add);
            Console.WriteLine("Subtraction of both numbers: " + input1min);
            Console.WriteLine("Multiplication of both numbers: " + input1times);
            Console.WriteLine("Division of both numbers: " + input1div);
        }
    }
}
