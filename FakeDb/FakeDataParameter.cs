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
    //     Represents a parameter to a Command object, and optionally, its mapping to System.Data.DataSet
    //     columns; and is implemented by .NET Framework data providers that access data
    //     sources.
    public class FakeDataParameter : IDataParameter
    {
        //
        // Summary:
        //     Gets or sets the System.Data.DbType of the parameter.
        //
        // Returns:
        //     One of the System.Data.DbType values. The default is System.Data.DbType.String.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The property was not set to a valid System.Data.DbType.
        public DbType DbType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets or sets a value indicating whether the parameter is input-only, output-only,
        //     bidirectional, or a stored procedure return value parameter.
        //
        // Returns:
        //     One of the System.Data.ParameterDirection values. The default is Input.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The property was not set to one of the valid System.Data.ParameterDirection values.
        public ParameterDirection Direction
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether the parameter accepts null values.
        //
        // Returns:
        //     true if null values are accepted; otherwise, false. The default is false.
        public bool IsNullable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets or sets the name of the System.Data.IDataParameter.
        //
        // Returns:
        //     The name of the System.Data.IDataParameter. The default is an empty string.
        public string ParameterName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets or sets the name of the source column that is mapped to the System.Data.DataSet
        //     and used for loading or returning the System.Data.IDataParameter.Value.
        //
        // Returns:
        //     The name of the source column that is mapped to the System.Data.DataSet. The
        //     default is an empty string.
        public string SourceColumn
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets or sets the System.Data.DataRowVersion to use when loading System.Data.IDataParameter.Value.
        //
        // Returns:
        //     One of the System.Data.DataRowVersion values. The default is Current.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The property was not set one of the System.Data.DataRowVersion values.
        public DataRowVersion SourceVersion
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets or sets the value of the parameter.
        //
        // Returns:
        //     An System.Object that is the value of the parameter. The default value is null.
        public object Value
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
