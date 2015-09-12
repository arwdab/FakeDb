using System;
using System.Data;

namespace FakeDb
{

    //
    // Summary:
    //     Represents a parameter to a Command object, and optionally, its mapping to System.Data.DataSet
    //     columns
    public class FakeDataParameter : IDataParameter
    {
        public FakeDataParameter()
        {
            ParameterName = "";
            SourceColumn = "";
        }

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
        private DbType dbType = DbType.String;
        public DbType DbType
        {
            get
            {
                return dbType;
            }
            set
            {
                if (!Enum.IsDefined(typeof(DbType), value))
                    throw new ArgumentOutOfRangeException("DbType - value");

                dbType = value;
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
        private ParameterDirection direction = ParameterDirection.Input;
        public ParameterDirection Direction
        {
            get
            {
                return direction;
            }
            set
            {
                if (!Enum.IsDefined(typeof(ParameterDirection), value))
                    throw new ArgumentException("Direction - value");

                direction = value;
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether the parameter accepts null values.
        //
        // Returns:
        //     true if null values are accepted; otherwise, false. The default is false.
        public bool IsNullable { get; private set; }

        //
        // Summary:
        //     Gets or sets the name of the FakeDataParameter.
        //
        // Returns:
        //     The name of the FakeDataParameter. The default is an empty string.
        public string ParameterName { get; set; }

        //
        // Summary:
        //     Gets or sets the name of the source column that is mapped to the System.Data.DataSet
        //     and used for loading or returning the FakeDataParameter.Value.
        //
        // Returns:
        //     The name of the source column that is mapped to the System.Data.DataSet. The
        //     default is an empty string.
        public string SourceColumn { get; set; }

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
        private DataRowVersion sourceVersion = DataRowVersion.Current;
        public DataRowVersion SourceVersion
        {
            get
            {
                return sourceVersion;
            }
            set
            {
                if (!Enum.IsDefined(typeof(DataRowVersion), value))
                    throw new ArgumentException("SourceVersion - value");

                sourceVersion = value;
            }
        }

        //
        // Summary:
        //     Gets or sets the value of the parameter.
        //
        // Returns:
        //     An System.Object that is the value of the parameter. The default value is null.
        public object Value { get; set; }
    }
}
