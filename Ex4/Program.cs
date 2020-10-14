using System;

namespace Ex4
{   /*4- Write a program that picks a random number between 1 and 10. 
    Give the user 4 chances to guess the number. If the user guesses the 
    number, display “You won"; otherwise, display “You lost". 
    (To make sure the program is behaving correctly, you can display 
    the secret number on the console first.)*/
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine(number);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the Number: ");
                int guessNumber = int.Parse(Console.ReadLine());
                if (number == guessNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            Console.WriteLine("You Lost");
        }
    }
}
}
