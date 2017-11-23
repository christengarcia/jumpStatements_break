using System;

namespace jumpStatements_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("i = {0}", i);

                if (i == 5)
                    break; /* The break keyword causes the program
                to exit a loop prematurely when a certain condition
                is me.*/ 
            }
        }
    }
}
