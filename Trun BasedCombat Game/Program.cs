using System;

namespace TurnBasedCombatGame
{
    class Program
    {
        static void Main()
        {
            int PlayerHp = 40;
            int EnemyHp = 20;

            int playerAttack = 5;
            int EnemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (PlayerHp > 0 && EnemyHp > 0)
            {
                // Player turn
                Console.WriteLine("-- Player Turn -- ");
                Console.WriteLine($"Player HP: {PlayerHp} | Enemy HP: {EnemyHp}");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string input = Console.ReadLine();
                char ch = input.Length > 0 ? input[0] : 'a';

                if (ch == 'a')
                {
                    EnemyHp -= playerAttack;
                    Console.WriteLine($"Player attacks the enemy and deals {playerAttack} damage!");
                }
                else
                {
                    PlayerHp += healAmount;
                    Console.WriteLine($"Player heals for {healAmount} health points!");
                }

                // Enemy turn
                if (EnemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine($"Player HP: {PlayerHp} | Enemy HP: {EnemyHp}");

                    int EnemyChoice = random.Next(0, 2);

                    if (EnemyChoice == 1)
                    {
                        PlayerHp -= EnemyAttack;
                        Console.WriteLine($"Enemy attacks and deals {EnemyAttack} damage!");
                    }
                    else
                    {
                        EnemyHp += healAmount;
                        Console.WriteLine($"Enemy heals for {healAmount} health points!");
                    }
                }
            }

            // Result
            if (PlayerHp > 0)
            {
                Console.WriteLine(" Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine(" You lost. Better luck next time!");
            }
        }
    }
}
