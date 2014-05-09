using System;

public class Line : DrawingObject
{
  public override void Draw()
  {
    Console.WriteLine("I am a line.");
  }
}

public class Circle : DrawingObject
{
  public override void Draw()
  {
    Console.WriteLine("I am a circle.");
  }
}

public class Square : DrawingObject
{
  public override void Draw()
  {
    Console.WriteLine("I am a square.");
  }
}

