using System;
using System.Collections.Generic;
class Program 
{
  static void Main (string[]args)
  {
    List<int> damages=new List<int>();
    damages.Add(10);
    damages.Add(30);
    damages.Add(50);
    damages.Add(20);
    int criticalHits=0;
    foreach(int damage in damages)
    {
      if(damage>=50)
        Console.WriteLine("Critical damage!");
      criticalHits++;
    }
    else if (damage>=30)
    {
      Console.WriteLine("High damage!");
    }
    else
    {
      Console.WriteLine("Normal damage!");
    }
  } 
  Console.WriteLine("Total Critical Hits: " + criticalHits);
}
}
