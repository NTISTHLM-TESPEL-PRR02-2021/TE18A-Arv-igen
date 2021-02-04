using System;

namespace Arv
{
  public class Potion
  {
    protected int amount = 20;

    //public bool isSmall = false;


    // public Potion(int amount)
    // {
    //   this.amount = amount;
    // }

    public virtual void Use(Player target)
    {
      target.hp += amount;

      // if (!isSmall)
      // {
      //   target.hp += 20;
      // }
      // else
      // {
      //   target.hp += 2;
      // }
    }

  }
}
