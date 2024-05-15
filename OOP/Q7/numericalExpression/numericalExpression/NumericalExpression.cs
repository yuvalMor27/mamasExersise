using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numericalExpression
{
    class NumericalExpression
    {
        public long Number { get; set; }
        private long _number;

        public NumericalExpression(long number)
        {
            Number = number;
            _number = Number;
        }




        public string ToString(long _number)
        {
            if (_number == 0)
            {
                return "zero";
            }

            if (_number < 0)
            {
                _number = Math.Abs(_number);
                return "minus " + ToString();
            }

            string words = "";
            if ((_number / 1000000000) > 0)
            {
                words += ToString(_number / 1000000000) + " billion  ";
                _number %= 1000000000;
            }

            if ((_number / 1000000) > 0)
            {
                words += ToString(_number / 1000000) + " million ";
                _number %= 1000000;
            }

            if ((_number / 1000) > 0)
            {
                words += ToString(_number / 1000) + " thousand ";
                _number %= 1000;
            }

            if ((_number / 100) > 0)
            {
                words += ToString(_number / 100) + " hundred ";
                _number %= 100;
            }

            if (_number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (_number < 20)
                    words += unitsMap[_number];
                else
                {
                    words += tensMap[_number / 10];
                    if ((_number % 10) > 0)
                        words += "-" + unitsMap[_number % 10];
                }
            }

            return words;
        }

        public long ReturnVal()
        {
            return _number;
        }
    }
}
