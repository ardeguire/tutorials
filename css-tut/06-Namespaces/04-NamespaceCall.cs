using System;

namespace csharp_station
{
  namespace tutorial
  {
    class myExample1
    {
      public static void myPrint()
      {
        Console.WriteLine("First example of calling anohter namespace member.");
      }
    }
  }

  class NamespaceCalling
  {
    public static void Main()
    {
      tutorial.myExample1.myPrint();
      tutorial.myExample2.myPrint();
    }
  }
}

// same nested namespace as above
namespace csharp_station.tutorial
{
  class myExample2
  {
    public static void myPrint()
    {
      Console.WriteLine("Second example of calling another namespace member.");
    }
  }
}

