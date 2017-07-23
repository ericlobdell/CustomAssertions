using System.Threading;

namespace Assertions
{
  public static class WaitAssert
  {
    private static AssertInvoker invoker = new AssertInvoker();

    private static void Wait(int timeInMilliseconds) =>
      Thread.Sleep(timeInMilliseconds);

    public static AssertInvoker WaitSeconds(int seconds)
    {
      Wait(seconds * 1000);
      return invoker;
    }

    public static AssertInvoker WaitMilliSeconds(int milliSeconds)
    {
      Wait(milliSeconds);
      return invoker; 
    }
  }
}
