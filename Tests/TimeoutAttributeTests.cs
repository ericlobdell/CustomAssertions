using System.Collections.Generic;
using Tests.Attributes;
using Xunit;


namespace Tests
{
  [Timeout(2000)]
  public class TimeoutAttributeTests
  {
    [Fact]
    public void Timeout_doesnt_fail_when_test_passes_before_time_expires1()
    {
      var passTest = Helpers.PassAfterThreeAttempts();
      Assert.True(passTest);
    }

    [Fact, Timeout(2000)]
    public void Timeout_fails_when_test_doesnt_pass_before_time_expires()
    {
      Assert.False(true); 
    }
  } 

  public static class Helpers
  {
    static int timesCalled = 0;

    static Dictionary<string, int> callCounts = new Dictionary<string, int>();

    public static bool PassAfterThreeAttempts()
    {
      timesCalled++;

      return timesCalled > 3;
    }
  }
}
