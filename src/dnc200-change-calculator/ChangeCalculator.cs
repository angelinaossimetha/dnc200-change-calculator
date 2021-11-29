using System;
using System.Collections.Generic;
using System.Text;

namespace dnc200_change_calculator
{
    public class ChangeCalculator
    {    
        private static decimal[] bills = { 1, 0.25m, 0.10m, 0.05m, 0.01m };
        private static string[,] billsStr = { { "dollars", "dollar" }, { "quarters", "quarter" },
                                               { "dimes", "dime" }, {"nickels", "nickel"},
                                               {"pennies", "penny"}};
        private static int N = bills.Length;
        
        public ChangeCalculator() { }

        public string GetChange(decimal owned, decimal given)
        {
            string output = "";
            decimal change = given - owned; 
            if (change == 0) {
                return  "No change is due";
            }
            if (change < 0 ) { output = "You are still owed"; }
            if (change > 0 ) { output = "The total change due is"; }
            change = Math.Abs(change);
            for (int i = 0; i < N; i++)
            {
                int count = 0;
                while (change >= bills[i])
                {
                    change = Decimal.Subtract(change, bills[i]);
                    count += 1; 
                }
                if (count == 1)
                {
                    output += " " + count + " " + billsStr[i, 1];
                } else
                {
                    output += " " + count + " " + billsStr[i, 0];
                }
            }

            return output;
        }
    }
}
