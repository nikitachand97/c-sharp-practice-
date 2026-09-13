using System;

class Program
{
    static void Main(string[] args)
    {
        int health = 70;
        int level = 8;
        int coins = 120;
        bool hasSword = true;
        int enemyHealth = 50;

        if (health > 0 && level >= 5 && hasSword)
        {
            Console.WriteLine("Player can fight!");
        }
        else
        {
            Console.WriteLine("Player cannot fight!");
        }

        if (enemyHealth > 0)
        {
            Console.WriteLine("Enemy is alive!");
        }
        else
        {
            Console.WriteLine("Enemy defeated!");
        }

        if (enemyHealth > 0 && hasSword)
        {
            Console.WriteLine("Player attacks the enemy!");
        }
        else
        {
            Console.WriteLine("Player cannot attack!");
        }

        if (health >= 70)
        {
            Console.WriteLine("Player is healthy");
        }
        else if (health >= 30)
        {
            Console.WriteLine("Player needs caution");
        }
        else
        {
            Console.WriteLine("Player is in danger");
        }

        if (health > 0 && enemyHealth > 0)
        {
            Console.WriteLine("Battle is ongoing!");
        }
        else
        {
            Console.WriteLine("Battle is over!");
        }

        if (coins >= 100)
        {
            Console.WriteLine("Player can buy a weapon");
        }
        else if (coins >= 50)
        {
            Console.WriteLine("Player can buy a potion");
        }
        else
        {
            Console.WriteLine("Not enough coins");
        }
    }
}
