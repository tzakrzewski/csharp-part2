using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class DbActivity : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to Processing.");
        }
    }
}
