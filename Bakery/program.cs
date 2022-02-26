using System;
using Bakery;

namespace BakeryInterface
{
  public class Program
  {
    public static void Main()
    {
      int check = 0;
      Bread myBread = new Bread();
      Pastry myPastry = new Pastry();
      Console.WriteLine("\n   -------------------------");
      Console.WriteLine("   | Welcome to my bakery! |");
      Console.WriteLine("   |  1 loaf of bread: $" + myBread.Cost + "  |");
      Console.WriteLine("   |     1 pastry: $" + myPastry.Cost + "      |");
      while (check == 0)
      {
        Console.WriteLine("   -------------------------\n");
        Console.WriteLine("How many loaves of Bread do you want?");
        myBread.Amount = int.Parse(Console.ReadLine());
        Console.WriteLine("How many Pastries do you want?");
        myPastry.Amount = int.Parse(Console.ReadLine());
        Console.WriteLine("Purchase " + myBread.Amount + " loaves of bread and " + myPastry.Amount + " pastries for $" + "19" + "? (Y/N)");
        if (Console.ReadLine().ToLower() == "y")
        {
          Console.WriteLine("Thank for for shopping with us, goodbye\n---------------------------------------");
          return;
        }
        Console.WriteLine("Enter M to modify your order or Q to quit.");
        if (Console.ReadLine().ToLower() == "q")
        {
          Console.WriteLine("Goodbye.\n--------");
          return;
        }
      }
    }
  }
}