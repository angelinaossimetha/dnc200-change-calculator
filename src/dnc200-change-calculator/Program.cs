using System;
using System.Linq;

namespace dnc200_change_calculator
{
    public class Program
    {
        static void Main(string[] args)
        { 
            ChangeCalculator calculator = new ChangeCalculator();
            decimal given;
            decimal owned;

            Console.WriteLine("Welcome to the Change Calculator App");

            Console.WriteLine("Enter amount given:");
            given = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter amount owned:");
            owned = Convert.ToDecimal(Console.ReadLine());

            string output = calculator.GetChange(owned, given);

            Console.WriteLine(output);

        }
    }
}
