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
    // Width = 5
    // Height = 7
    // (using object initializer syntax)
    Rectangle rect2 = new Rectangle(5, 7);

    // show the value of Width and Height
    Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

    Console.ReadKey();
  }
}

