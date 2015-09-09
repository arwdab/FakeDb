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
    //     Used by the Visual Basic .NET Data Designers to represent a parameter to a Command
    //     object
    public class FakeDbDataParameter : FakeDataParameter, IDbDataParameter
    {
        //
        // Summary:
        //     Indicates the precision of numeric parameters.
        //
        // Returns:
        //     The maximum number of digits used to represent the Value property of a data provider
        //     Parameter object. The default value is 0, which indicates that a data provider
        //     sets the precision for Value.
        public byte Precision
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
        //     Indicates the scale of numeric parameters.
        //
        // Returns:
        //     The number of decimal places to which System.Data.OleDb.OleDbParameter.Value
        //     is resolved. The default is 0.
        public byte Scale
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
        //     The size of the parameter.
        //
        // Returns:
        //     The maximum size, in bytes, of the data within the column. The default value
        //     is inferred from the the parameter value.
        public int Size
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
