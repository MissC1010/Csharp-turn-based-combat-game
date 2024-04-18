using System;

namespace TurnBasedCombatGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;
            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                // Players turn
                Console.WriteLine("--Players turn--");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine($"Player attacks enemy and deals {playerAttack} damage!");
                    Console.WriteLine($"Enemy health is currently {enemyHp}");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine($"Player restores {healAmount} health points.");
                }

                // Enemy's turn
                if (enemyAttack > 0)
                {
                    Console.WriteLine("Enemy's turn");
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Enemy attacks and deals {enemyAttack} damage");
                        Console.WriteLine($"Player's health is currently {playerHp}");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine($"Enemy restores {healAmount} health points");
                    }
                }
            }

            // Check for win or lose
            if (playerHp <= 0)
            {
                Console.WriteLine("You lose! Game over.");
            }
            else
            {
                Console.WriteLine("You win! Congratulations!");
            }
        }
    }
}
