using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class UploadActivity : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}
