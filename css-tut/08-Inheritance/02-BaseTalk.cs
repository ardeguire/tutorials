using System;

public class Parent
{
  string parentString;
  
  // default constructor
  public Parent()
  {
    Console.WriteLine("Parent Constructor.");
  }

  public Parent(string myString)
  {
    parentString = myString;
    Console.WriteLine(parentString);
  }

  public void print()
  {
    Console.WriteLine("I'm a parent class.");
  }
}

public class Child : Parent
{
  public Child() : base("From Derived")
  {
    Console.WriteLine("Child Constructor.");
  }

  public new void print()
  {
    base.print(); // Parent.print
    Console.WriteLine("I'm a child class.");
  }

  public static void Main()
  {
    Child child = new Child();
    // Child.print
    child.print();
    // Parent.print
    ((Parent)child).print();
  }
}

