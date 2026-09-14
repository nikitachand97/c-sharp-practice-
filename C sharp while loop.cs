using System;

class Program
{
    static void Main(string[] args)
    {
        int enemyHealth = 40;
        int damage = 10;

        while (enemyHealth > 0)
        {
            Console.WriteLine("Player attacks!");
            enemyHealth -= damage;

            if (enemyHealth <= 0)
            {
                Console.WriteLine("Enemy defeated!");
            }
            else
            {
                Console.WriteLine("Enemy still alive!");
            }
        }
    }
}
