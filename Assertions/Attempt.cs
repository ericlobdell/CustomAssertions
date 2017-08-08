using System;
using System.Diagnostics;

namespace Xunit
{
  public static class Attempt
  {
     public static void ForMilliseconds(long timoutInMilliseconds, Action assertion)
    {
      Stopwatch timer = new Stopwatch();
      timer.Start();

      while (timer.ElapsedMilliseconds <= timoutInMilliseconds)
      {
        try
        {
          Thread.Sleep(100);
          assertion();
          break;
        }
        catch (Exception) {
          if (timer.ElapsedMilliseconds >= timoutInMilliseconds)
            assertion();
        }
      }

      if (timer.ElapsedMilliseconds >= timoutInMilliseconds)
        assertion();
    }

    public static void ForSeconds(int timoutInSeconds, Action assertion) =>
      ForMilliseconds(timoutInSeconds * 1000, assertion);
  }
}
