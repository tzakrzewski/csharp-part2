using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class SetupActivity : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding."); ;
        }
    }
}
