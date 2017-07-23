using Xunit;

namespace Assertions
{
  public class AssertInvoker
  {
    public AssertInvoker False(bool condition, string userMessage = null)
    {
      Assert.False(condition, userMessage);
      return this;
    }
      
    public AssertInvoker False(bool? condition, string userMessage = null)
    {
      Assert.False(condition, userMessage);
      return this;
    }

    public AssertInvoker True(bool condition, string userMessage = null)
    {
      Assert.True(condition, userMessage);
      return this;
    }

    public AssertInvoker True(bool? condition, string userMessage = null)
    {
      Assert.True(condition, userMessage);
      return this;
    }
  }
}
