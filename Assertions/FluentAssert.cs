using Assertions;

namespace Xunit
{
  public partial class Assert
  {
    public static FluentAsserter Fluent() => new FluentAsserter();
  }
}
