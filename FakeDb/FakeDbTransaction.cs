using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDb
{    //
    // Summary:
    //     Represents a transaction to be performed at a data source
    public class FakeDbTransaction : IDbTransaction
    {
        //
        // Summary:
        //     Specifies the Connection object to associate with the transaction.
        //
        // Returns:
        //     The Connection object to associate with the transaction.
        public IDbConnection Connection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Specifies the System.Data.IsolationLevel for this transaction.
        //
        // Returns:
        //     The System.Data.IsolationLevel for this transaction. The default is ReadCommitted.
        public IsolationLevel IsolationLevel
        {
            get
            {
                throw new NotImplementedException();
            }
        }

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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Dispose() { }
    }
}
