using System;

class Address
{
  public string name;
  public string address;
}

class MethodParams
{
  public static void Main()
  {
    string myChoice;

    MethodParams mp = new MethodParams();

    do
    {
      // show menu and get input from user
      myChoice = mp.getChoice();

      // make decision baed on user's choice
      mp.makeDecision(myChoice);

      //let the user see the results
      Console.Write("Press \"Enter\" to continue...");
      Console.ReadLine();
      Console.WriteLine();
    } while (myChoice != "Q" && myChoice != "q"); //go until user quits
  }

  // show menu and get user's choice
  string getChoice()
  {
    string myChoice;

    //print a menu
    Console.WriteLine("My Address Book\n");

    Console.WriteLine("A - Add new address");
    Console.WriteLine("D - Delete address");
    Console.WriteLine("M - Modify address");
    Console.WriteLine("V - View addresses");
    Console.WriteLine("Q - Quit\n");

    Console.Write("Choice: ");

    //Get user choice
    myChoice = Console.ReadLine();
    Console.WriteLine();

    return myChoice;
  }

  // make decision
  void makeDecision(string myChoice)
  {
    Address addr = new Address();

    switch(myChoice)
    {
      case "A":
      case "a":
        addr.name = "Adam";
        addr.address = "Columbus OH";
        this.addAddress(ref addr);
        break;
      case "D":
      case "d":
        addr.name = "Robert";
        this.deleteAddress(addr.name);
        break;
      case "M":
      case "m":
        addr.name = "Matt";
        this.modifyAddress(out addr);
        Console.WriteLine("Name is now {0}", addr.name);
        break;
      case "V":
      case "v":
        this.viewAddresses("Cheryl", "Joe", "Matt", "Robert");
        break;
      case "Q":
      case "q":
        Console.WriteLine("Bye.");
        break;
      default:
        Console.WriteLine("{0} is not a valid choice.", myChoice);
        break;
    }
  }

  //insert an address
  void addAddress(ref Address addr)
  {
    Console.WriteLine("Name: {0}\nAddress: {1}\nAdded.", addr.name, addr.address);
  }

  //remove an address
  void deleteAddress(string name)
  {
    Console.WriteLine("You are deleting {0}'s address.", name);
  }

  //change an address
  void modifyAddress(out Address addr)
  {
    addr = new Address();
    addr.name = "Joe";
    addr.address = "C# Station";
  }

  // show addresses
  void viewAddresses(params string[] names)
  {
    foreach(string name in names)
    {
      Console.WriteLine("Name: {0}", name);
    }
  }
}

