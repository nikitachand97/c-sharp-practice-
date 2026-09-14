using System;

class Program
{
    static void Main(string[] args)
    {
        int enemyHealth = 30;
        int damage = 10;

        do
        {
            Console.WriteLine("Player attacks!");
            enemyHealth -= damage;
        }
        while (enemyHealth > 0);
    }
}
