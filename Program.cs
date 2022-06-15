using System;

namespace CsharpPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExercisesClass - StopWatch Exercise
            //var stopWatch = new StopWatch();
            //stopWatch.Start();
            //System.Threading.Thread.Sleep(45000);
            //stopWatch.Stop();
            //stopWatch.Duration();

            //ExercisesClass - Post Exercise
            //var post = new Post("Breakfast", "This is a sample post, green eggs and hams says Sam I Am!");
            //post.SetUpVote();
            //post.SetUpVote();
            //post.SetDownVote();
            //post.SetDownVote();
            //post.SetDownVote();
            //post.DisplayVotes();

            //ExercisesInheritance - Stack
            var stack = new Stack();
            stack.Push(1); 
            stack.Push(2); 
            stack.Push(3);
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}

