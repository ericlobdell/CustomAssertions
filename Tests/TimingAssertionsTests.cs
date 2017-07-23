﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
