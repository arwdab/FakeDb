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
    //     Provides access to the column values within each row for a DataReader
    public class FakeDataRecord : IDataRecord
    {
        //
        // Summary:
        //     Gets the column with the specified name.
        //
        // Parameters:
        //   name:
        //     The name of the column to find.
        //
        // Returns:
        //     The column with the specified name as an System.Object.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     No column with the specified name was found.
        public object this[string name]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets the column located at the specified index.
        //
        // Parameters:
        //   i:
        //     The zero-based index of the column to get.
        //
        // Returns:
        //     The column located at the specified index as an System.Object.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public object this[int i]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets the number of columns in the current row.
        //
        // Returns:
        //     When not positioned in a valid recordset, 0; otherwise, the number of columns
        //     in the current record. The default is -1.
        public int FieldCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets the value of the specified column as a Boolean.
        //
        // Parameters:
        //   i:
        //     The zero-based column ordinal.
        //
        // Returns:
        //     The value of the column.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the 8-bit unsigned integer value of the specified column.
        //
        // Parameters:
        //   i:
        //     The zero-based column ordinal.
        //
        // Returns:
        //     The 8-bit unsigned integer value of the specified column.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Reads a stream of bytes from the specified column offset into the buffer as an
        //     array, starting at the given buffer offset.
        //
        // Parameters:
        //   i:
        //     The zero-based column ordinal.
        //
        //   fieldOffset:
        //     The index within the field from which to start the read operation.
        //
        //   buffer:
        //     The buffer into which to read the stream of bytes.
        //
        //   bufferoffset:
        //     The index for buffer to start the read operation.
        //
        //   length:
        //     The number of bytes to read.
        //
        // Returns:
        //     The actual number of bytes read.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the character value of the specified column.
        //
        // Parameters:
        //   i:
        //     The zero-based column ordinal.
        //
        // Returns:
        //     The character value of the specified column.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Reads a stream of characters from the specified column offset into the buffer
        //     as an array, starting at the given buffer offset.
        //
        // Parameters:
        //   i:
        //     The zero-based column ordinal.
        //
        //   fieldoffset:
        //     The index within the row from which to start the read operation.
        //
        //   buffer:
        //     The buffer into which to read the stream of bytes.
        //
        //   bufferoffset:
        //     The index for buffer to start the read operation.
        //
        //   length:
        //     The number of bytes to read.
        //
        // Returns:
        //     The actual number of characters read.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Returns an System.Data.IDataReader for the specified column ordinal.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The System.Data.IDataReader for the specified column ordinal.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the data type information for the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The data type information for the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the date and time data value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The date and time data value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the fixed-position numeric value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The fixed-position numeric value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the double-precision floating point number of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The double-precision floating point number of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the System.Type information corresponding to the type of System.Object that
        //     would be returned from System.Data.IDataRecord.GetValue(System.Int32).
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The System.Type information corresponding to the type of System.Object that would
        //     be returned from System.Data.IDataRecord.GetValue(System.Int32).
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the single-precision floating point number of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The single-precision floating point number of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Returns the GUID value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The GUID value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the 16-bit signed integer value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The 16-bit signed integer value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the 32-bit signed integer value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The 32-bit signed integer value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the 64-bit signed integer value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The 64-bit signed integer value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the name for the field to find.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The name of the field or the empty string (""), if there is no value to return.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public string GetName(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Return the index of the named field.
        //
        // Parameters:
        //   name:
        //     The name of the field to find.
        //
        // Returns:
        //     The index of the named field.
        public int GetOrdinal(string name)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the string value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The string value of the specified field.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Return the value of the specified field.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     The System.Object which will contain the field value upon return.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public object GetValue(int i)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Populates an array of objects with the column values of the current record.
        //
        // Parameters:
        //   values:
        //     An array of System.Object to copy the attribute fields into.
        //
        // Returns:
        //     The number of instances of System.Object in the array.
        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Return whether the specified field is set to null.
        //
        // Parameters:
        //   i:
        //     The index of the field to find.
        //
        // Returns:
        //     true if the specified field is set to null; otherwise, false.
        //
        // Exceptions:
        //   T:System.IndexOutOfRangeException:
        //     The index passed was outside the range of 0 through System.Data.IDataRecord.FieldCount.
        public bool IsDBNull(int i)
        {
            throw new NotImplementedException();
        }
    }
}
