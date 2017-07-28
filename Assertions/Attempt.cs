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
          assertion();
          break;
        }
        catch (Exception){}
      }
    }

    public static void ForSeconds(int timoutInSeconds, Action assertion) =>
      ForMilliseconds(timoutInSeconds * 1000, assertion);
  }
}
