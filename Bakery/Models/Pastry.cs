using System;

namespace Bakery
{
  public class Pastry
  {
    public int Amount {get; set;}
    
    public Pastry(int amount)
    {
      Amount = amount;
    }
    public int GetCost()
    {
      return 0;
    }
  }
}