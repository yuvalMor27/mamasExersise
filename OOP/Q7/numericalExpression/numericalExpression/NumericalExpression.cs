using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numericalExpression
{
    class NumericalExpression
    {
        public static long Number { get; set; }

        public NumericalExpression(long number)
        {
            Number = number;
        }

        public string ToString(long num)
        {
            if (num == 0)
            {
                return "zero";
            }

            if (num < 0)
            {
                num = Math.Abs(num);
                return "minus " + ToString();
            }

            string words = "";
            if ((num / 1000000000) > 0)
            {
                words += ToString(num / 1000000000) + " billion ";
                num %= 1000000000;
            }

            if ((num / 1000000) > 0)
            {
                words += ToString(num / 1000000) + " million ";
                num %= 1000000;
            }

            if ((num / 1000) > 0)
            {
                words += ToString(num / 1000) + " thousand ";
                num %= 1000;
            }

            if ((num / 100) > 0)
            {
                words += ToString(num / 100) + " hundred ";
                num %= 100;
            }

            if (num > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num < 20)
                    words += unitsMap[num];
                else
                {
                    words += tensMap[num / 10];
                    if ((num % 10) > 0)
                        words += "-" + unitsMap[num % 10];
                }
            }
            return words;
        }

        public long GetValue()
        {
            return Number;
        }

        public static int SumLetters(int numToSum)
        { 
            int lunNum = 0;
            for (int num = 0; num <= numToSum; num++)
            {
                NumericalExpression x = new NumericalExpression(numToSum);
                string word = x.ToString(num);
                int space = 0;
                for (int index = 0; index < word.Length; index++)
                {
                    if (word[index] == ' ')
                    {
                        space++;
                    }
                }
                lunNum += word.Length - space;
            }
            return lunNum;
        }


        //Polymorphism
        public static int SumLetters(NumericalExpression Number)
        {
            int lunNum = 0;
            for (int num = 0; num <= Number.GetValue(); num++)
            {
                NumericalExpression x = new NumericalExpression(Number.GetValue());
                string word = x.ToString(num);
                int space = 0;
                for (int index = 0; index < word.Length; index++)
                {
                    if (word[index] == ' ')
                    {
                        space++;
                    }
                }
                lunNum += word.Length - space;
            }
            return lunNum;
        }
    }
}

