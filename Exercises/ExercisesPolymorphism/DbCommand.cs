using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    class DbCommand
    {
        private string _instructions;
        private readonly DbConnection _dbConnection;
        public DbCommand(DbConnection dbConnection, string instructions)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("Database Connection is Null");

            if (string.IsNullOrEmpty(instructions))
                throw new ArgumentNullException("Instructions do not exist");

            _dbConnection = dbConnection;
            _instructions = instructions;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running Instructions: {0}", _instructions);
            _dbConnection.CloseConnection();
        }
    }

}
