using System;
using Bakery;

namespace BakeryInterface
{
  public class Program
  {
    public static void Main()
    {
      bool check = true;
      Bread myBread = new Bread();
      Pastry myPastry = new Pastry();
      Welcome(myBread.Cost, myPastry.Cost);
      while (check)
      {
        Console.WriteLine("\n   How many loaves of Bread do you want?\n   Current deal: Buy 2, get 1 Free!");
        while (myBread.Amount == -1)
        {
          myBread.Amount = getAmount();
        }
        Console.WriteLine("   Added " + myBread.Amount + " loaves.");
        Console.WriteLine("\n   How many Pastries do you want?\n   Current deal: Get 3 for $5!");
        while (myPastry.Amount == -1)
        {
          myPastry.Amount = getAmount();
        }
        Console.WriteLine("   Added " + myPastry.Amount + " pastries.");
        check = Finish(myBread, myPastry);
      }
    }

    public static void Welcome(int cost1, int cost2)
    {
      Console.WriteLine("\n   -------------------------");
      Console.WriteLine("   | Welcome to my bakery! |");
      Console.WriteLine("   |  1 loaf of bread: $" + cost1 + "  |");
      Console.WriteLine("   |     1 pastry: $" + cost2 + "      |");
      Console.WriteLine("   -------------------------");
    }

    public static int getAmount()
    {
      int amount = 0;
      if (int.TryParse(Console.ReadLine(), out amount))
      {
        if (amount >= 0)
        {
          return amount;
        }
        Console.WriteLine("   Enter a positive amount.");
      }
      else
      {
        Console.WriteLine("   Make sure to only enter a whole number.");
      }
      return -1;
    }

    public static bool Finish(Bread myBread, Pastry myPastry)
    {
      Console.WriteLine("\n   Purchase " + myBread.Amount + " loaves of bread and " + myPastry.Amount + " pastries for $" + (myBread.GetCost(myBread.Amount) + myPastry.GetCost(myPastry.Amount)) + "? (Y/N)");
      if (Console.ReadLine().ToLower() == "y")
      {
        Console.WriteLine("   Thank for for shopping with us, goodbye.\n---------------------------------------\n");
      }
      else
      {
        Console.WriteLine("   Enter M to modify your order or C to cancel the order.");
        if (Console.ReadLine().ToLower() != "c")
        {
          myBread.Amount = -1;
          myPastry.Amount = -1;
          return true;
        }
        else
        {
          Console.WriteLine("   Goodbye.\n--------------\n");
        }
      }
      return false;
    }
  }
}