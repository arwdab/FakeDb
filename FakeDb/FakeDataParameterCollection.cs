using System;
using System.Collections;
using System.Data;

namespace FakeDb
{
    //
    // Summary:
    //     Collects all parameters relevant to a Command object and their mappings to System.Data.DataSet
    //     columns.
    public class FakeDataParameterCollection : IDataParameterCollection
    {
        //
        // Summary:
        //     Initializes a new instance of the FakeDb.FakeDataParameterCollection class.
        public FakeDataParameterCollection()
        {

        }

        //
        // Summary:
        //     Gets or sets the element at the specified index.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the element to get or set.
        //
        // Returns:
        //     The element at the specified index.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is not a valid index in the collection.
        //
        //   T:System.NotSupportedException:
        //     The property is set and the Object is not implementing IDataParameter.
        public object this[int index]
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
        //     Gets or sets the parameter at the specified index.
        //
        // Parameters:
        //   parameterName:
        //     The name of the parameter to retrieve.
        //
        // Returns:
        //     An System.Object at the specified index.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The property is set and the Object is not implementing IDataParameter.
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
        //     Gets the number of elements contained in the collections.
        //
        // Returns:
        //     The number of elements contained in the collection.
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether the collections has a fixed size.
        //
        // Returns:
        //     Always returns false.
        public bool IsFixedSize
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether the collections is read-only.
        //
        // Returns:
        //     Always returns false.
        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets a value indicating whether access to the collections
        //     is synchronized (thread safe).
        //
        // Returns:
        //     Always returns false (collection is not thread safe).
        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Gets an object that can be used to synchronize access to the collection.
        //
        // Returns:
        //     An object that can be used to synchronize access to the collection.
        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //
        // Summary:
        //     Adds an item to the collection.
        //
        // Parameters:
        //   value:
        //     The object to add to the collection.
        //
        // Returns:
        //     The position into which the new element was inserted, or -1 to indicate that
        //     the item was not inserted into the collection.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The added Object is not implementing IDataParameter. 
        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Removes all items from the collection.
        public void Clear()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Determines whether the collection contains a specific value.
        //
        // Parameters:
        //   value:
        //     The object to locate in the collection.
        //
        // Returns:
        //     true if the System.Object is found in the collection; otherwise,
        //     false.
        public bool Contains(object value)
        {
            throw new NotImplementedException();
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
        //     Copies the elements of the collection to an System.Array,
        //     starting at a particular System.Array index.
        //
        // Parameters:
        //   array:
        //     The one-dimensional System.Array that is the destination of the elements copied
        //     from collection. The System.Array must have zero-based indexing.
        //
        //   index:
        //     The zero-based index in array at which copying begins.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     array is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero.
        //
        //   T:System.ArgumentException:
        //     array is multidimensional.-or- The number of elements in the source collection
        //     is greater than the available space from index to the end of the destination
        //     array.-or-The type of the source collection cannot be cast
        //     automatically to the type of the destination array.
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Returns an enumerator that iterates through the collection.
        //
        // Returns:
        //     An System.Collections.IEnumerator object that can be used to iterate through
        //     the collection.
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Determines the index of a specific item in the collection.
        //
        // Parameters:
        //   value:
        //     The object to locate in the collection.
        //
        // Returns:
        //     The index of value if found in the collection; otherwise, -1.
        public int IndexOf(object value)
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
        //     Inserts an item to the collection at the specified index.
        //
        // Parameters:
        //   index:
        //     The zero-based index at which value should be inserted.
        //
        //   value:
        //     The object to insert into the collection.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is not a valid index in the collection.
        //
        //   T:System.NullReferenceException:
        //     value is null reference in the collection.
        //
        //   T:System.NotSupportedException:
        //     The inserted Object is not implementing IDataParameter. 
        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Removes the first occurrence of a specific object from the collection.
        //
        // Parameters:
        //   value:
        //     The object to remove from the collection.
        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Removes the collection item at the specified index.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the item to remove.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is not a valid index in the collection.
        public void RemoveAt(int index)
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
