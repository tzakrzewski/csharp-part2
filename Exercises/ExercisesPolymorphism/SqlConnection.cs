using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) 
            : base(connection){ }
        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQl Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Connection");
        }
    }
}
