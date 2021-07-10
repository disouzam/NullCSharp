// Testing instructions from this article below
// https://dev.to/matheusgomes062/coalescing-operator-and-compound-assignment-operator-in-c-3ae3

using System;

namespace NullCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      double? x = null;
      double? y = 10.0;

      // check if x is null
      if (x.HasValue)
        Console.WriteLine(x.Value);
      else
        Console.WriteLine("X is null");

      // check if y is null
      if (y.HasValue)
        Console.WriteLine(y.Value);
      else
        Console.WriteLine("Y is null");
    }
  }
}
