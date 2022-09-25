using System;
using curso_c_sharp.CodeWars;

namespace curso_c_sharp_test.CodeWars
{
  [TestFixture]
  public class StopWatchTest
  {
    public StopWatchTest()
    {
    }

    [Test]
    public void StartStopWatch()
    {
      StopWatch.Start();
      System.Threading.Thread.Sleep(2000);
      StopWatch.Stop();
      Assert.That(StopWatch.Duration().Seconds, Is.EqualTo(2));
    }

    [Test]
    public void StartWatch()
    {
      StopWatch.Start();
      var exception = Assert.Throws<ArgumentException>(() => StopWatch.Duration());
      Assert.That(exception.Message, Is.EqualTo("Stop watch must be started and stopped at least once to calculate a duration."));
    }

    [Test]
    public void TryToStopWatch()
    {
      var exception = Assert.Throws<ArgumentException>(() => StopWatch.Stop());
      Assert.That(exception.Message, Is.EqualTo("Stop watch is not started."));
    }

    [Test]
    public void TryDuration()
    {
      var exception = Assert.Throws<ArgumentException>(() => StopWatch.Duration());
      Assert.That(exception.Message, Is.EqualTo("Stop watch must be started and stopped at least once to calculate a duration."));
    }

    [Test]
    public void TryWithoutStopWatch()
    {
      StopWatch.Start();
      var exception = Assert.Throws<ArgumentException>(() => StopWatch.Duration());
      Assert.That(exception.Message, Is.EqualTo("Stop watch must be started and stopped at least once to calculate a duration."));
    }

  }
}
