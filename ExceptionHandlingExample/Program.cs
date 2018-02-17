using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

            operation.ToPrint();
            operation.ToCheckNullException();
            operation.Add();

            Console.ReadLine();
        }
    }
}
