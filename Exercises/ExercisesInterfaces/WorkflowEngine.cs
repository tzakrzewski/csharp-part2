using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class WorkflowEngine
    {
        private readonly List<IActivities> _workflow;

        public WorkflowEngine(List<IActivities> workflow)
        {
            _workflow = workflow;
        }
        public void Run()
        {
            foreach (var activty in _workflow)
            {
                activty.Execute();
            }
        }
    }
}
