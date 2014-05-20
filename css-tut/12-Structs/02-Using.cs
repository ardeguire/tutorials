using System;

/// <summary>
/// Example of declaring and using a struct.
/// </summary>
class StructExample
{
  /// <summary>
  /// Entry point.
  /// </summary>
  static void Main()
  {
    // instantiate a new Rectangle struct
    // Width = 1
    // Height = 3
    // (using object initializer syntax)
    Rectangle rect1 = new Rectangle
    {
      Width = 1,
      Height = 3
    };

    // show the value of Width and Height
    Console.WriteLine("rect1: {0}:{1}", rect1.Width, rect1.Height);

    Console.ReadKey();
  }
}

