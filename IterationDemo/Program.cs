using System;

namespace IterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Samira Matin";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var j = 1;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
        }
    }
}
