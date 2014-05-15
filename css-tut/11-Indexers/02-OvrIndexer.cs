using System;

/// <summary>
///   A simple indexer example.
/// </summary>
class OvrIndexer
{
  private string[] myData;
  private int arrSize;

  public OvrIndexer(int size)
  {
    arrSize = size;
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

  public string this[string data]
  {
    get
    {
      int count = 0;

      for (int i = 0; i < arrSize; i++)
      {
        if (myData[i] == data)
        {
          count++;
        }
      }
      return count.ToString();
    }
    set
    {
      for (int i = 0; i < arrSize; i++)
      {
        if (myData[i] == data)
        {
          myData[i] = value;
        }
      }
    }
  }

  static void Main(string[] args)
  {
    int size = 10;

    OvrIndexer myIndex = new OvrIndexer(size);

    myIndex[9] = "Some value";
    myIndex[2] = "another value";
    myIndex[5] = "arbitrary value";

    myIndex["empty"] = "no value";

    Console.WriteLine("\nIndexer Output\n");

    for (int i = 0; i < size; i++)
    {
      Console.WriteLine("myIndex[{0}]: {1}", i, myIndex[i]);
    }

    Console.WriteLine("\nNumber of \"no value\" entries: {0}", myIndex["no value"]);
  }
}

