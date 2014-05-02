using System;

class DoLoop
{
  public static void Main()
  {
    string myChoice;

    do
    {
      //print a menu
      Console.WriteLine("My Address Book\n");

      Console.WriteLine("A - Add new address");
      Console.WriteLine("D - Delete address");
      Console.WriteLine("M - Modify address");
      Console.WriteLine("V - View addresses");
      Console.WriteLine("Q - Quit\n");

      Console.WriteLine("Choice: ");

      //Get user choice
      myChoice = Console.ReadLine();

      switch(myChoice)
      {
        case "A":
        case "a":
          Console.WriteLine("You're going to add an address");
          break;
        case "D":
        case "d":
          Console.WriteLine("You're going to delete an address.");
          break;
        case "M":
        case "m":
          Console.WriteLine("You're going to modify an address.");
          break;
        case "V":
        case "v":
          Console.WriteLine("You wish to view the address book.");
          break;
        case "Q":
        case "q":
          Console.WriteLine("Bye.");
          break;
        default:
          Console.WriteLine("{0} is not a valid choice.", myChoice);
          break;
      }

      //let the user see the results
      Console.Write("Press \"Enter\" to continue...");
      Console.ReadLine();
      Console.WriteLine();
    } while (myChoice != "Q" && myChoice != "q"); //go until user quits
  }
}

