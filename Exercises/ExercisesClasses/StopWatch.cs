using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running = false;  
        
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Can't start stopwatch twice in a row");
            
            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
            _running = false;
        }

        public void Duration()
        {
            Console.WriteLine(_stopTime - _startTime);
        }
    }
}
//    Design a class called Stopwatch.The job of this class is to simulate a stopwatch.
//    It should provide two methods: Start and Stop.We call the start method first, and the stop method next.
//    Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan.
//    Display the duration on the console. We should also be able to use a stopwatch multiple times.
//    So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly. 
//    We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). 
//    So the class should throw an InvalidOperationException if its started twice

