using System;

interface ParentInterface
{
  void ParentInterfaceMethod();
}

interface MyInterface : ParentInterface
{
  void MethodToImplement();
}

class InterfaceImplementer : MyInterface
{
  static void Main()
  {
    InterfaceImplementer imp = new InterfaceImplementer();
    imp.MethodToImplement();
    imp.ParentInterfaceMethod();
  }

  public void MethodToImplement()
  {
    Console.WriteLine("MethodToImplement() called.");
  }

  public void ParentInterfaceMethod()
  {
    Console.WriteLine("ParentInterfaceMethod() called.");
  }
}

