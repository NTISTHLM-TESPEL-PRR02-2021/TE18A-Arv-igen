using System.Drawing;
using System;
using System.Collections.Generic;

namespace Arv
{
  class Program
  {
    static void Main(string[] args)
    {
      Player p1 = new Player("Ralf");
      Potion potion = new Potion();


      SmallPotion smallPotion = new SmallPotion();

      Potion p = new SmallPotion();

      // List<Potion> potions = new List<Potion>();

      // potions.Add(new Potion());
      // potions.Add(new SmallPotion());
      // potions.Add(new Potion());

      // potions[1].Use(p1);


      // potion.isSmall = false;

      Potion rand = new RandomPotion();

      Console.WriteLine(p1.name + ": " + p1.hp);

      rand.Use(p1);

      //potion.Use(p1);

      // smallPotion.Use(p1);

      Console.WriteLine(p1.name + ": " + p1.hp);

      Console.ReadLine();
      
    }
  }
}
