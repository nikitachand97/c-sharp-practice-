using System;
class Program
{
static void Main (string [] args)
{
int[] coins={10,20,30,40,50};
int totalCoins=0;
foreach (int coin in coins)
{
totalCoins= totalCoins+coin;
}
Console.WriteLine("Total Coins : " + totalCoins);;
}
}
