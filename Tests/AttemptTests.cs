using System.Diagnostics;
using Xunit;

namespace Tests
{
  public class AttemptTests
  {
    [Fact]
    public void ForMilliseconds_returns_before_timeout_when_test_passes()
    {
      var timeout = 3000;
      var timer = new Stopwatch();

      timer.Start();
      Attempt.ForMilliseconds(timeout, () => Assert.True(true));

      Assert.True(timer.ElapsedMilliseconds < timeout);
    }

    [Fact]
    public void ForMilliseconds_returns_after_timeout_when_test_fails()
    {
      var timeout = 3000;
      var timer = new Stopwatch();

      timer.Start();
      Attempt.ForMilliseconds(timeout, () => Assert.True(false));

      Assert.True(timer.ElapsedMilliseconds >= timeout);
    }

    [Fact]
    public void ForSeconds_returns_before_timeout_when_test_passes()
    {
      var timeout = 3;
      var timer = new Stopwatch();

      timer.Start();
      Attempt.ForSeconds(timeout, () => Assert.True(true));

      Assert.True(timer.Elapsed.Seconds < timeout);
    }

    [Fact]
    public void ForSeconds_returns_after_timeout_when_test_fails()
    {
      var timeout = 3;
      var timer = new Stopwatch();

      timer.Start();
      Attempt.ForSeconds(timeout, () => Assert.True(false));

      Assert.True(timer.Elapsed.Seconds >= timeout);
    }
  }
}
