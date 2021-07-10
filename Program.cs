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

      x ??= 0.0;
      y ??= 0.0;
      Console.WriteLine(x.Value);
      Console.WriteLine(y.Value);
    }
  }
}
