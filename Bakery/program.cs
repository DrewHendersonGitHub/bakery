using System;

namespace BakeryInterface
{
  public class Program
  {
    public static void Main()
    {
      int check = 0;
      Console.WriteLine("-------------------------");
      Console.WriteLine("| Welcome to my bakery! |");
      Console.WriteLine("|  1 loaf of bread: $" + "5" + "  |");
      Console.WriteLine("|     1 pastry: $" + "4" + "      |");
      while (check == 0)
      {
        Console.WriteLine("-------------------------");
        Console.WriteLine("How many loaves of Bread do you want?");
        Console.ReadLine();
        Console.WriteLine("How many Pastries do you want?");
        Console.ReadLine();
        Console.WriteLine("Purchase " + "3" + " loaves of bread and " + "7" + " pastries for $" + "19" + "? (Y/N)");
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