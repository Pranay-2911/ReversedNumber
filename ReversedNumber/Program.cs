using ReversedNumber.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());

            int reverse = Reverse.ToReverse(number);

            Console.WriteLine($"The Reverse of a number is {reverse}");
        }
    }
}
