using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDb
{
    //
    // Summary:
    //     A database connection used to fake a database during testing.
    public class FakeDbConnection : IDbConnection
    {
        //
        // Summary:
        //     Gets or sets the string used to open a database.
        //     Not used anywhere by FakeDb
        //
        // Returns:
        //     A string containing connection settings.
        public string ConnectionString { get; set; }

        //
        // Summary:
        //     Gets the time to wait while trying to establish a connection before terminating
        //     the attempt and generating an error.
        //
        // Returns:
        //     The time (in seconds) to wait for a connection to open. The default value is
        //     15 seconds.
        private int connectionTimeout = 15;
        public int ConnectionTimeout {
            get { return connectionTimeout; }
            private set { connectionTimeout = value; }
        }

        //
        // Summary:
        //     Gets the name of the current database or the database to be used after a connection
        //     is opened.
        //
        // Returns:
        //     The name of the current database or the name of the database to be used once
        //     a connection is open. The default value is an empty string.
        public string Database { get; }

        //
        // Summary:
        //     Gets the current state of the connection.
        //
        // Returns:
        //     One of the System.Data.ConnectionState values.
        public ConnectionState State { get; }

        //
        // Summary:
        //     Begins a database transaction.
        //
        // Returns:
        //     An object representing the new transaction.
        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Begins a database transaction with the specified System.Data.IsolationLevel value.
        //
        // Parameters:
        //   il:
        //     One of the System.Data.IsolationLevel values.
        //
        // Returns:
        //     An object representing the new transaction.
        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Changes the current database for an open Connection object.
        //
        // Parameters:
        //   databaseName:
        //     The name of the database to use in place of the current database.
        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Closes the connection to the database.
        public void Close()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Creates and returns a Command object associated with the connection.
        //
        // Returns:
        //     A Command object associated with the connection.
        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Opens a database connection with the settings specified by the ConnectionString
        //     property of the provider-specific Connection object.
        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
