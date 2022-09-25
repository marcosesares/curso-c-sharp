using System;
namespace curso_c_sharp.CodeWars
{
  /*
  <summary>
    Design a class called Stopwatch. The job of this class is to simulate a stopwatch.
    It should provide two methods: Start and Stop.
    We call the start method first, and the stop method next. 
    Then we ask the stopwatch about the duration between start and stop.
    Duration should be a value in TimeSpan.
    Display the duration on the console. 
    We should also be able to use a stopwatch multiple times.
    So we may start and stop it and then start and stop it again.
    Make sure the duration value each time is calculated properly. 
    We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time).
    So the class should throw an InvalidOperationException if its started twice.
  <summary>
  */
  public class StopWatch
  {
    private static DateTime _Start;
    private static DateTime _Stop;
    private static bool _Started;
    private static bool _Stopped;

    private StopWatch()
    {
    }

    public static void Start()
    {
      if (_Started)
      {
        throw new ArgumentException("Stop watch is already started.");
      }
      _Started = true;
      _Start = DateTime.Now;
    }

    public static void Stop()
    {
      if (!_Started)
      {
        throw new ArgumentException("Stop watch is not started.");
      }
      _Started = false;
      _Stopped = true;
      _Stop = DateTime.Now;
    }

    public static TimeSpan Duration()
    {
      if (_Started || !_Stopped)
      {
        throw new ArgumentException("Stop watch must be started and stopped at least once to calculate a duration.");
      }
      var duration = _Stop - _Start;
      Console.WriteLine("Duration: {0}", duration);
      return duration;
    }
  }
}

