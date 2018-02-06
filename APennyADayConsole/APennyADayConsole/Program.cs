using System;

namespace APennyADayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;
            long count = 0;
            long numDays = 0;
            long pennyTotal = 1;
            double dollarValue;

            Console.WriteLine("Enter number of days: ");
            input = Console.ReadLine();

            numDays = Convert.ToInt64(input);

            while (count != numDays)
            {
                pennyTotal = pennyTotal + pennyTotal;
                Console.WriteLine("cur " + pennyTotal);
                count++;
            }

            dollarValue = pennyTotal / 100.0;

            output = Math.Round(dollarValue, 2).ToString();

            Console.WriteLine("Total in cents is: " + pennyTotal);
            Console.WriteLine("Total in Dollars is: $" + output);

            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey(true);
        }
    }
}
