using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumber.Model
{
    internal class Reverse
    {
        public static int ToReverse(int number)
        {
            int tempValue = number;
            int reverse = 0;
            int minValue = 0;
            int divisor = 10;
            int multiple = 10;

            //Perfrom the reverse of number 
            while (tempValue > minValue)
            {
                int lastNumber = tempValue % divisor;
                reverse = (reverse * multiple) + lastNumber;
                tempValue = tempValue / divisor;
            }
            return reverse;
        }
    }
}
