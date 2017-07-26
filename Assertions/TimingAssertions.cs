using Assertions;
using System.Threading;

namespace Xunit
{
  public partial class Assert
  {
    static FluentAssert invoker = new FluentAssert();

    public static FluentAssert Fluent()
    {
      return invoker;
    }

    public static FluentAssert WaitMilliseconds(int milliseconds)
    {
      Thread.Sleep(milliseconds);
      return invoker;
    }

    public static FluentAssert WaitSeconds(int seconds)
    {
      Thread.Sleep(seconds * 1000);
      return invoker;
    }
  }
}
