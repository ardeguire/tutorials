using System;

/// <summary>
///   A simple indexer example.
/// </summary>
class IntIndexer
{
  private string[] myData;

  public IntIndexer(int size)
  {
    myData = new string[size];

    for (int i = 0; i < size; i++)
    {
      myData[i] = "empty";
    }
  }

  public string this[int pos]
  {
    get
    {
      return myData[pos];
    }
    set
    {
      myData[pos] = value;
    }
  }

  static void Main(string[] args)
  {
    int size = 10;

    IntIndexer myIndex = new IntIndexer(size);

    myIndex[9] = "Some value";
    myIndex[2] = "another value";
    myIndex[5] = "arbitrary value";

    Console.WriteLine("\nIndexer Output\n");

    for (int i = 0; i < size; i++)
    {
      Console.WriteLine("myIndex[{0}]: {1}", i, myIndex[i]);
    }
  }
}

