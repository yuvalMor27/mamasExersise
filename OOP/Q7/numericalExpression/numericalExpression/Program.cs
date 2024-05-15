using System;

namespace numericalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression num = new NumericalExpression(1570);
            Console.WriteLine(num.ToString(999999999999));
        }
    }
}
