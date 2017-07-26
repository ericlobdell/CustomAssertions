using Assertions;
using System.Threading;

namespace Xunit
{
  public partial class Assert
  {
    static FluentAsserter invoker = new FluentAsserter();

    public static FluentAsserter WaitMilliseconds(int milliseconds)
    {
      Thread.Sleep(milliseconds);
      return invoker;
    }

    public static FluentAsserter WaitSeconds(int seconds)
    {
      Thread.Sleep(seconds * 1000);
      return invoker;
    }
  }
}
