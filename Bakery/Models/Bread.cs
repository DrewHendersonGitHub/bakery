using System;

namespace Bakery
{
  public class Bread
  {
    public int Amount {get; set;}

    public Bread(int amount)
    {
      Amount = amount;
    }
    public int GetCost()
    {
      return 5 * (Amount - (int)Convert.ToSingle(Amount / 3));
    }
  }
}