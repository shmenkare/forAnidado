using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace forAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            char m = ' ';

            for (n = 1; n <= 5; n++ )
            {

                for (m = 'a'; m <= 'z'; m++)
                {
                    Thread.Sleep(50);

                    Console.Write(m);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
