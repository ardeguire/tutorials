using System;

// helper class
class OutputClass
{
  string myString;

  //constructor
  public OutputClass(string inputString)
  {
    myString = inputString;
  }

  //instance method
  public void printString()
  {
    Console.WriteLine("{0}", myString);
  }

  //destructor
  ~OutputClass()
  {
    //resouce cleanup
  }
}

//program class
class ExampleClass
{
  public static void Main()
  {
    OutputClass outCl = new OutputClass("This is printed by OutputClass");

    outCl.printString();
  }
}

