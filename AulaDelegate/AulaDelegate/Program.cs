using System;
using Course.Services;

namespace AulaDelegate
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double result = CalculationService.Square(a);

            Console.WriteLine(result);

        }

    }
}
