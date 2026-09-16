using System;
using System.Collections.Generic;
class Program 
{
  static void Main (string[]args)
  {
    List<string> items=new List<string>();
    items.Add("Sword");
    items.Add("Potion");
    items.Add("Shield");
    items.Add("Bow");

    foreach(string item in items)
    {
      Console.WriteLine(item);
      if(item=="Sword")
      {
        Console.WriteLine("Weapon found!");
      }
      else if(item=="Potion")
      {
        Console.WriteLine("Healing item is found!");
      }
      else
      {
        Console.WriteLine("Other item");
      }
    }
  }
}
