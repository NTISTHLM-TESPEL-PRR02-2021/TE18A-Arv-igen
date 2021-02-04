using System;

namespace Arv
{
  public class RandomPotion : Potion
  {
    static Random generator = new Random();

    public override void Use(Player target)
    {
      target.hp += generator.Next(2, 20);
    }

  }
}
