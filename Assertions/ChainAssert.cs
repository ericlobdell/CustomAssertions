using Assertions;

namespace Xunit
{
  public partial class Assert
  {
    public static AssertInvoker Chain() => new AssertInvoker();
  }
}
