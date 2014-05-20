using System;

public class StructExampe
{
  /// <summary>
  /// Entry point: execution starts here.
  /// </summary>
  static void Main()
  {
    // instantiate  a Rectangle struct
    // Width = 1
    // Height = 3
    Rectangle rect1 = new Rectangle();
    rect1.Width = 1;
    rect1.Height = 3;

    // show values for rect1
    Console.WriteLine("rect1: {0}:{1}", rect1.Width, rect1.Height);

    // instantiate a Rectangle struct
    // Wdith = 5
    // Height = 7
    Rectangle rect2 = new Rectangle(5,7);

    // show values for rect2
    Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

    // invoke the Add method on the rect1 Rectangle struct instance,
    // passing the rect2 Rectangle struct instance as an argument
    // and assigning the new copy of the value returned by the
    // Add method to the rect3 Rectangle struct.
    Rectangle rect3 = rect1.Add(rect2);

    // show values for rect3
    Console.WriteLine("rect3: {0}:{1}", rect3.Width, rect3.Height);
  }
}

