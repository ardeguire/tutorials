using System;
using csTut = csharp_station.tutorial.myExample; //alias

class AliasDirective
{
  public static void Main()
  {
    csTut.myPrint();
    myPrint();
  }

  // potentially ambiguous method
  static void myPrint()
  {
    Console.WriteLine("Not a member of csharp_station.tutorial.myExample.");
  }
}

namespace csharp_station.tutorial
{
  class myExample
  {
    public static void myPrint()
    {
      Console.WriteLine("This is a member of csharp_station.tutorial.myExample.");
    }
  }
}

