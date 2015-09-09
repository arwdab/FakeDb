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
    //     Represents an SQL statement that is executed while connected to a data source.
    public class FakeDbCommand : IDbCommand
    {
        //
        // Summary:
        //     Gets or sets the text command to run against the data source.
        //
        // Returns:
        //     The text command to execute. The default value is an empty string ("").
        public string CommandText { get; set; }

        //
        // Summary:
        //     Gets or sets the wait time before terminating the attempt to execute a command
        //     and generating an error.
        //
        // Returns:
        //     The time (in seconds) to wait for the command to execute. The default value is
        //     30 seconds.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The property value assigned is less than 0.
        public int CommandTimeout { get; set; }

        //
        // Summary:
        //     Indicates or specifies how the System.Data.IDbCommand.CommandText property is
        //     interpreted.
        //
        // Returns:
        //     One of the System.Data.CommandType values. The default is Text.
        public CommandType CommandType { get; set; }

        //
        // Summary:
        //     Gets or sets the System.Data.IDbConnection used by this instance of the System.Data.IDbCommand.
        //
        // Returns:
        //     The connection to the data source.
        public IDbConnection Connection { get; set; }

        //
        // Summary:
        //     Gets the System.Data.IDataParameterCollection.
        //
        // Returns:
        //     The parameters of the SQL statement or stored procedure.
        public IDataParameterCollection Parameters { get; }

        //
        // Summary:
        //     Gets or sets the transaction within which the Command object of a .NET Framework
        //     data provider executes.
        //
        // Returns:
        //     the Command object of a .NET Framework data provider executes. The default value
        //     is null.
        public IDbTransaction Transaction { get; set; }

        //
        // Summary:
        //     Gets or sets how command results are applied to the System.Data.DataRow when
        //     used by the System.Data.IDataAdapter.Update(System.Data.DataSet) method of a
        //     System.Data.Common.DbDataAdapter.
        //
        // Returns:
        //     One of the System.Data.UpdateRowSource values. The default is Both unless the
        //     command is automatically generated. Then the default is None.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The value entered was not one of the System.Data.UpdateRowSource values.
        public UpdateRowSource UpdatedRowSource { get; set; }

        //
        // Summary:
        //     Attempts to cancels the execution of an System.Data.IDbCommand.
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Creates a new instance of an System.Data.IDbDataParameter object.
        //
        // Returns:
        //     An IDbDataParameter object.
        public IDbDataParameter CreateParameter()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Executes an SQL statement against the Connection object of a .NET Framework data
        //     provider, and returns the number of rows affected.
        //
        // Returns:
        //     The number of rows affected.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The connection does not exist.-or- The connection is not open.
        public int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Executes the System.Data.IDbCommand.CommandText against the System.Data.IDbCommand.Connection
        //     and builds an System.Data.IDataReader.
        //
        // Returns:
        //     An System.Data.IDataReader object.
        public IDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Executes the System.Data.IDbCommand.CommandText against the System.Data.IDbCommand.Connection,
        //     and builds an System.Data.IDataReader using one of the System.Data.CommandBehavior
        //     values.
        //
        // Parameters:
        //   behavior:
        //     One of the System.Data.CommandBehavior values.
        //
        // Returns:
        //     An System.Data.IDataReader object.
        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Executes the query, and returns the first column of the first row in the resultset
        //     returned by the query. Extra columns or rows are ignored.
        //
        // Returns:
        //     The first column of the first row in the resultset.
        public object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Creates a prepared (or compiled) version of the command on the data source.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Data.OleDb.OleDbCommand.Connection is not set.-or- The System.Data.OleDb.OleDbCommand.Connection
        //     is not System.Data.OleDb.OleDbConnection.Open.
        public void Prepare()
        {
            throw new NotImplementedException();
        }

        public void Dispose() { }
    }
}
