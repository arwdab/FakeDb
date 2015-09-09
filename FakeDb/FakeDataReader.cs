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
    //     Provides a means of reading one or more forward-only streams of result sets obtained
    //     by executing a command at a data source, and is implemented by .NET Framework
    //     data providers that access relational databases.
    public class FakeDataReader : FakeDataRecord, IDataReader
    {
        //
        // Summary:
        //     Gets a value indicating the depth of nesting for the current row.
        //
        // Returns:
        //     The level of nesting.
        public int Depth
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether the data reader is closed.
        //
        // Returns:
        //     true if the data reader is closed; otherwise, false.
        public bool IsClosed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets the number of rows changed, inserted, or deleted by execution of the SQL
        //     statement.
        //
        // Returns:
        //     The number of rows changed, inserted, or deleted; 0 if no rows were affected
        //     or the statement failed; and -1 for SELECT statements.
        public int RecordsAffected
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        //
        // Summary:
        //     Closes the System.Data.IDataReader Object.
        public void Close()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Returns a System.Data.DataTable that describes the column metadata of the System.Data.IDataReader.
        //
        // Returns:
        //     A System.Data.DataTable that describes the column metadata.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Data.IDataReader is closed.
        public DataTable GetSchemaTable()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Advances the data reader to the next result, when reading the results of batch
        //     SQL statements.
        //
        // Returns:
        //     true if there are more rows; otherwise, false.
        public bool NextResult()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Advances the System.Data.IDataReader to the next record.
        //
        // Returns:
        //     true if there are more rows; otherwise, false.
        public bool Read()
        {
            throw new NotImplementedException();
        }

        public void Dispose() { }
    }
}
