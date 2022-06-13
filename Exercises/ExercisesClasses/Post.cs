using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class Post
    {
        private DateTime _created;
        public string _title { get;  set; }
        public string _description { get; set; }
        private int _upVote = 0;
        private int _downVote = 0;
        private int _testing;
        public int Testing
        {
            get { return _testing; }
            set { _testing = value; }
        }

        public Post(string title, string desc)
        {
            _title = title;
            _description = desc;
            _created = DateTime.Now;
        }

        public void SetUpVote()
        {
            _upVote += 1;
        }
        public void SetDownVote()
        {
            _downVote += 1;
        }

        public void DisplayVotes()
        {
            Console.WriteLine(String.Format("Title: {0}", _title));
            Console.WriteLine(String.Format("Description: {0}", _description));
            Console.WriteLine(String.Format("Up Votes: {0} Down Votes: {1}", _upVote, _downVote));
        }
        public void TestingDisplay()
        {
            _testing = 3;
            Console.WriteLine(_testing);
        }
    }
}
//    Design a class called Post.This class models a StackOverflow post. It should have properties 
//    for title, description and the date/time it was created. We should be able to up-vote or
//    down-vote a post. We should also be able to see the current vote value. In the main method,
//    create a post, up-vote and down-vote it a few times and then display the the current vote value. 
//    In this exercise, you will learn that a StackOverflow post should provide methods for up-voting 
//    and down-voting. You should not give the ability to set the Vote property from the outside, 
//    because otherwise, you may accidentally change the votes of a class to 0 or to a random number. 
//    And this is how we create bugs in our programs. The class should always protect its state and hide its implementation detail. 
