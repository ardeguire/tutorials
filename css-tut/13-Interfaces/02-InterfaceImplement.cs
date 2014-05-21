class InterfaceImplement : MyInterface
{
  static void Main()
  {
    InterfaceImplement iImp = new InterfaceImplement();
    iImp.MethodToImplement();
  }

  public void MethodToImplement()
  {
    System.Console.WriteLine("MethodToImplement() called.");
  }
}

