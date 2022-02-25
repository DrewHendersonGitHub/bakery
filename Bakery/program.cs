using System;

namespace BakeryInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-------------------------");
      Console.WriteLine("| Welcome to my bakery! |");
      Console.WriteLine("|  1 loaf of bread: $" + "5" + "  |");
      Console.WriteLine("|     1 pastry: $" + "4" + "      |");
      Console.WriteLine("-------------------------");
      Console.WriteLine("How many loaves of Bread do you want?");
      Console.ReadLine();
      Console.WriteLine("How many pastries do you want?");
      Console.ReadLine();
      Console.WriteLine("Purchase " + "3" + " loaves of bread and " + "7" + " Pastries for $" + "19" + "? (Y/N)");
      if (Console.ReadLine().ToLower() == "y")
      {
        Console.WriteLine("Thank for for shopping with us, goodbye");
        return;
      }
      else
      {
        Console.WriteLine("Enter M to modify your order or Q to quit.");
      }
      Console.WriteLine("ssssssssssssssss");
    }
  }
}