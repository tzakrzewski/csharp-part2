using System;
using System.Collections.Generic;

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
            //var stack = new Stack();
            //stack.Push(1); 
            //stack.Push(2); 
            //stack.Push(3);
            //Console.WriteLine(stack.Pop()); 
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //ExercisesPolymorphism - DbConnection Part 1
            //var oracleConnection = new OracleConnection("Oracle Connection");
            //var sqlConnection = new SqlConnection("SQL Connection");

            //var connections = new List<DbConnection>();
            //connections.Add(oracleConnection);
            //connections.Add(sqlConnection);

            //foreach(var connection in connections)
            //{
            //    connection.OpenConnection();
            //    connection.CloseConnection();
            //}

            //ExercisesPolymorphism - DbConnection Part 2
            //var oracleCommand = new DbCommand(new OracleConnection("Oracle Connection"), "This is an Oracle Instruction, Work!");
            //var sqlCommand = new DbCommand(new SqlConnection("Sql Connection"), "This is an SQL Instruction, Sleep!");
            ////var blowUp = new DbCommand(null, "hello");

            //var commands = new List<DbCommand>();
            //commands.Add(oracleCommand);
            //commands.Add(sqlCommand);

            //foreach (var command in commands)
            //{
            //    command.Execute();
            //}

            ////ExercisesInterfaces - WorkflowEngine
            //var workflow = new List<IActivities>();
            //workflow.Add(new UploadActivity());
            //workflow.Add(new SetupActivity());
            //workflow.Add(new EmailActivity());
            //workflow.Add(new DbActivity());

            //var workflowEngine = new WorkflowEngine(workflow);
            //workflowEngine.Run();
        }
    }
}

