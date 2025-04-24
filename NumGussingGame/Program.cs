using System;
using System.Numerics;

namespace NumGussingGame
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To The Number Game! ");
            Console.WriteLine();
            Console.WriteLine("A Number between 1 : 10 will be generated. ");
            Console.WriteLine();
            Console.WriteLine("if You Gusse Correct Number ,You win ");
            Console.WriteLine();


            int RandomNum;
            Random random = new Random();
            bool IsCorrect = false;
            int Enemy = random.Next(0, 10);

            Console.ReadKey();
            while (!IsCorrect)
            {
                Console.WriteLine("Enter Your gussed Number");
                RandomNum = Convert.ToInt32(Console.ReadLine());

                if (RandomNum == Enemy)
                {
                    Console.WriteLine("win");
                    IsCorrect = true;
                }
                else if (RandomNum > Enemy)
                {
                    Console.WriteLine("The gusse is High");
                }

                else
                {
                    Console.WriteLine("The gusse is Low");

                }
            }


        }

    }
}