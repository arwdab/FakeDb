using System;
using System.Data;

namespace FakeDb
{    //
    // Summary:
    //     Represents a transaction to be performed at a data source
    public class FakeDbTransaction : IDbTransaction
    {
        private bool commitedOrRollbacked = false;

        public FakeDbTransaction(IDbConnection connection)
            : this(connection, IsolationLevel.ReadCommitted)
        {
        }

        public FakeDbTransaction(IDbConnection connection, IsolationLevel isolationLevel)
        {
            if (connection == null)
                throw new ArgumentNullException("connection");

            Connection = connection;
            IsolationLevel = isolationLevel;
        }

        //
        // Summary:
        //     Specifies the Connection object to associate with the transaction.
        //
        // Returns:
        //     The Connection object to associate with the transaction.
        public IDbConnection Connection { get; private set; }

        //
        // Summary:
        //     Specifies the System.Data.IsolationLevel for this transaction.
        //
        // Returns: 
        //     The System.Data.IsolationLevel for this transaction. The default is ReadCommitted.
        public IsolationLevel IsolationLevel { get; private set; }

        //
        // Summary:
        //     Commits the database transaction.
        //
        // Exceptions:
        //   T:System.Exception:
        //     An error occurred while trying to commit the transaction.
        //
        //   T:System.InvalidOperationException:
        //     The transaction has already been committed or rolled back.-or- The connection
        //     is broken.
        public void Commit()
        {
            if (commitedOrRollbacked)
                throw new InvalidOperationException("Transaction is already commited or rollbacked.");

            commitedOrRollbacked = true;
        }

        //
        // Summary:
        //     Rolls back a transaction from a pending state.
        //
        // Exceptions:
        //   T:System.Exception:
        //     An error occurred while trying to commit the transaction.
        //
        //   T:System.InvalidOperationException:
        //     The transaction has already been committed or rolled back.-or- The connection
        //     is broken.
        public void Rollback()
        {
            if (commitedOrRollbacked)
                throw new InvalidOperationException("Transaction is already commited or rollbacked.");

            commitedOrRollbacked = true;
        }

        public void Dispose() { }
    }
}
