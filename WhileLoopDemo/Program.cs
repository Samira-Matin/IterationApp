using System;

namespace WhileLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 10;

            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            string password = new string(buffer);
            Console.WriteLine(password);

        }
    }
}
