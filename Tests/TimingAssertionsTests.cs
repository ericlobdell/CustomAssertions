using System.Diagnostics;
using Xunit;

namespace Tests
{
  public class TimingAssertionsTests
  {
    private Stopwatch timer;

    public TimingAssertionsTests()
    {
      timer = new Stopwatch();
    }

    [Fact]
    public void WaitMilliseconds_waits_before_making_assertion()
    {
      var waitTime = 2000;

      timer.Start();

      Assert
        .WaitMilliseconds(waitTime)
        .False(false)
        .Contains(1, new[] {1,2,3})
        .True(true);

      Assert.True(timer.ElapsedMilliseconds >= waitTime);
    }

    [Fact]
    public void WaitSeconds_waits_before_making_assertion()
    {
      var waitTime = 2;

      timer.Start();

      Assert
        .WaitSeconds(waitTime)
        .True(true);

      Assert.True(timer.ElapsedMilliseconds >= (waitTime * 1000));
    }
  }
}
