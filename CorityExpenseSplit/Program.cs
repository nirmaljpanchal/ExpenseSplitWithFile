using System;
using System.Collections.Generic;

namespace CorityExpenseSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please pass filename as an argument.");
            }
            else
            {
                string file = args[0];
                IReadExpense readExpense = new ReadExpense(file);
                List<ITripGroup> tripGroup = readExpense.GetTripGroups();
                IWriteExpense writeExpense = new WriteExpense(file+".out");
                writeExpense.WriteTripBalance(tripGroup);
                Console.WriteLine("Process completed.");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
