using System;

class Unary
{
  public static void Main()
  {
    int unary = 0;

    int preIncrement;
    int preDecrement;

    int postIncrement;
    int postDecrement;

    int positive;
    int negative;

    sbyte bitNot;
    bool logNot;

    preIncrement = ++unary;
    Console.WriteLine("pre-Increment: {0}", preIncrement);
    Console.WriteLine("unary: {0}", unary);

    preDecrement = --unary;
    Console.WriteLine("pre-Decrement: {0}", preDecrement);
    Console.WriteLine("unary: {0}", unary);

    postDecrement = unary--;
    Console.WriteLine("post-Decrement: {0}", postDecrement);
    Console.WriteLine("unary: {0}", unary);

    postIncrement = unary++;
    Console.WriteLine("post-Increment: {0}", postIncrement);

    Console.WriteLine("unary: {0}", unary);

    positive = -postIncrement;
    Console.WriteLine("Positive: {0}", positive);

    negative = +postIncrement;
    Console.WriteLine("Negative: {0}", negative);

    bitNot = 0;
    bitNot = (sbyte)(~bitNot);
    Console.WriteLine("Bitwise not: {0}", bitNot);

    logNot = false;
    logNot = !logNot;
    Console.WriteLine("Logical Not: {0}", logNot);
  }
}

