using Assertions;
using System.Threading;
using Xunit;

namespace Xunit
{
  public partial class Assert
  {
    static AssertInvoker invoker = new AssertInvoker();

    public static AssertInvoker WaitMilliseconds(int milliseconds)
    {
      Thread.Sleep(milliseconds);
      return invoker;
    }

    public static AssertInvoker WaitSeconds(int seconds)
    {
      Thread.Sleep(seconds * 1000);
      return invoker;
    }
  }
}
