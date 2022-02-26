using System;

namespace Bakery
{
  public class Bread
  {
    public int Cost {get; set;}
    public int Amount {get; set;}

    public Bread()
    {
      Cost = 5;
      Amount = -1;
    }
    public int GetCost(int amount)
    {
      Amount = amount;
      return 5 * (Amount - (int)Convert.ToSingle(Amount / 3));
    }
  }
}