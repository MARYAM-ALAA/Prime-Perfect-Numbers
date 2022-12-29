using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                int n, i, sum, First_Number, Last_Number;
          
                Console.WriteLine("Type Two Numbers To Get The Perfect Numbers in Range");
                Console.Write("------------------------------------------------------");
         
                Console.Write("The First Number in Range : ");
                First_Number = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Last Number in Range : ");
                Last_Number = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Perfect Numbers in Range Are : ");
                for (n = First_Number; n <= Last_Number; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }
        }

        
    }
                }
