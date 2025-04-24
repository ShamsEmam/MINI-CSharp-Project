using System;

namespace CalculatorApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            int PlayerRandomNum;
            int EnemyRondomNum;
            int PlayerPoints = 0;
            int EnemyPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Any key To Roll The Dice. ");

                Console.ReadKey();

                //generat randome number between 1 (inclusive) to 7(exclusive)
                PlayerRandomNum = random.Next(1, 7);
                Console.WriteLine();
                Console.WriteLine("You rolled " + PlayerRandomNum);

                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);

                EnemyRondomNum = random.Next(1, 7);
                Console.WriteLine("Enemy Ai rolled " + EnemyRondomNum);
                Console.WriteLine();

                if (PlayerRandomNum > EnemyRondomNum)
                {
                    PlayerPoints++;
                    Console.WriteLine("Player is wins this Round! ");
                    Console.WriteLine();
                }
                else if (EnemyRondomNum > PlayerRandomNum)
                {
                    EnemyPoints++;
                    Console.WriteLine("AI is wins this Round! ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Draw!");
                    Console.WriteLine();
                }

                Console.WriteLine("The Score is Now : Player " + PlayerPoints + " AI " + EnemyPoints);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();

            }
            if (PlayerPoints > EnemyPoints)
                Console.WriteLine("You Win!!!!!!!!!!!!!!!");
            else if (PlayerPoints < EnemyPoints)
                Console.WriteLine("Hard Lack......!");
            else
                Console.WriteLine("Draw!");
            Console.ReadKey();

        }
    }
}