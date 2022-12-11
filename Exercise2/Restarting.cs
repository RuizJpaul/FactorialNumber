using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Restarting
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the factorial: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("!0 = 1");
            }
            else if (num > 0)
            {
                Console.WriteLine("!0 = 1");
                for (int i = 1; i <= num; i++)
                {
                    Console.Write("!{0} = ", i);
                    //we need an accumulator to storage the factorial result 
                    long acc = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == i)
                        {
                            Console.Write("{0} ",j);
                            acc *= j;
                        }
                        else
                        {
                            Console.Write("{0} x ", j);
                            acc *= j;
                        }
                    }
                    Console.Write("---> "+acc);
                    Console.WriteLine();
                }
            }
        }
    }
}
