using System;

namespace Ex1
{
    /* Write a program to count how many numbers between 1 and 100 
 * are divisible by 3 with no remainder.Display the count on the 
 * console.*/
   class Program
        {
            static void Main(string[] args)
            {
                int count = 0;
                for (int i = 1; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                        count++;
                    }

                }
                Console.WriteLine($"Count of numbers between 1 and 100, which are divisible by 3 are: " + count);
            }
        }
    }
