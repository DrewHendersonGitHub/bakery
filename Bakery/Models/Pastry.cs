using System;

namespace Bakery
{
  public class Pastry
  {
    public int Cost {get; set;}
    public int Amount {get; set;}
    
    public Pastry()
    {
      Cost = 2;
    }
    public int GetCost(int amount)
    {
      Amount = amount;
      return 2 * (Amount) - (int)Convert.ToSingle(Amount / 3);
    }
  }
}