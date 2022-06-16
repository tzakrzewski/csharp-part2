using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection) { }
        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle Connection");
        }
    }
}
