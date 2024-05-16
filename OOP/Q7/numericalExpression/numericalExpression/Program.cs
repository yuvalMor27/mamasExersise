using System;

namespace numericalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression num = new NumericalExpression(77);
            Console.WriteLine(num.ToString(num.GetValue()));
            Console.WriteLine(NumericalExpression.SumLetters((int)num.GetValue()));
        }
    }
}
