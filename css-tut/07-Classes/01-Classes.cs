using System;

// helper class
class OutputClass
{
  string myString;

  //default constructor
  public OutputClass() : this("Default constructor string.") {}

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

  //static method
  public static void staticPrinter()
  {
    Console.WriteLine("I print things even when there are no instances of the class.");
  }
}

//program class
class ExampleClass
{
  public static void Main()
  {
    OutputClass.staticPrinter();

    OutputClass outCl = new OutputClass();
    outCl.printString();
    
    outCl = new OutputClass("This is printed by OutputClass");
    outCl.printString();
  }
}

