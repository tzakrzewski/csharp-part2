using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart2
{
    abstract class DbConnection
    {
        private string _connectionString;
        private readonly TimeSpan _timeOut = TimeSpan.FromSeconds(60);

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Connection String is Null or Empty");

            _connectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
