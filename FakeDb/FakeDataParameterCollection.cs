using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDb
{
    //
    // Summary:
    //     Collects all parameters relevant to a Command object and their mappings to System.Data.DataSet
    //     columns, and is implemented by .NET Framework data providers that access data
    //     sources.
    public class FakeDataParameterCollection : List<object>, IDataParameterCollection
    {
        //
        // Summary:
        //     Gets or sets the parameter at the specified index.
        //
        // Parameters:
        //   parameterName:
        //     The name of the parameter to retrieve.
        //
        // Returns:
        //     An System.Object at the specified index.
        public object this[string parameterName]
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
        //     Gets a value indicating whether a parameter in the collection has the specified
        //     name.
        //
        // Parameters:
        //   parameterName:
        //     The name of the parameter.
        //
        // Returns:
        //     true if the collection contains the parameter; otherwise, false.
        public bool Contains(string parameterName)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the location of the System.Data.IDataParameter within the collection.
        //
        // Parameters:
        //   parameterName:
        //     The name of the parameter.
        //
        // Returns:
        //     The zero-based location of the System.Data.IDataParameter within the collection.
        public int IndexOf(string parameterName)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Removes the System.Data.IDataParameter from the collection.
        //
        // Parameters:
        //   parameterName:
        //     The name of the parameter.
        public void RemoveAt(string parameterName)
        {
            throw new NotImplementedException();
        }
    }
}
