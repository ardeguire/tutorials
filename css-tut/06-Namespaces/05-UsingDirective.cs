using System;
using csharp_station.tutorial;

class UsingDirective
{
  public static void Main()
  {
    myExample.myPrint();
  }
}

//c# station tutorial namespace
namespace csharp_station.tutorial
{
  class myExample
  {
    public static void myPrint()
    {
      Console.WriteLine("Example of using a \'using\' directive.");
    }
  }
}

