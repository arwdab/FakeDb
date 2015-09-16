using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace FakeDb.Tests
{
    public class FakeDataParameterCollectionTests
    {
        [Fact]
        public void Count_WhenCollectionIsEmpty_ReturnsZero()
        {
            var sut = new FakeDataParameterCollection();

            Assert.Equal(0, sut.Count);
        }

        [Theory]
        [InlineData(new object[] { 1 })]
        [InlineData(new object[] { 2 })]
        [InlineData(new object[] { 5 })]
        public void Count_WhenAddedItems_ReturnsCorrectCount(int parameterCount)
        {
            var sut = new FakeDataParameterCollection();
            for (int i = 0; i < parameterCount; i++)
            {
                sut.Add(new FakeDataParameter());
            }

            Assert.Equal(parameterCount, sut.Count);
        }

        [Theory]
        [InlineData(new object[] { 1 })]
        [InlineData(new object[] { 2 })]
        [InlineData(new object[] { 5 })]
        public void Add_WithValidDataParameters_AddsParametes(int parameterCount)
        {
            var parameters = new List<IDataParameter>();
            var sut = new FakeDataParameterCollection();
            for (int i = 0; i < parameterCount; i++)
            {
                parameters.Add(new FakeDataParameter());
                sut.Add(parameters[i]);
            }

            for (int i = 0; i < parameterCount; i++)
            {
                Assert.Same(parameters[i], sut[i]);
            }
        }

        [Fact]
        public void Add_WithNull_Throws()
        {
            var sut = new FakeDataParameterCollection();

            Assert.Throws<ArgumentNullException>(() => sut.Add(null));
        }

        [Fact]
        public void Add_WithNonIDataParameterObject_Throws()
        {
            var sut = new FakeDataParameterCollection();

            Assert.Throws<InvalidCastException>(() => sut.Add(new Object()));
        }

        [Theory]
        [InlineData(new object[] { -1 })]
        [InlineData(new object[] { 1 })]
        public void IndexerGetter_WithOutOfIndex_Throws(int index)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());

            Assert.Throws<IndexOutOfRangeException>(() => sut[index]);
        }

        [Theory]
        [InlineData(new object[] { -1 })]
        [InlineData(new object[] { 1 })]
        public void IndexerSetter_WithOutOfIndex_Throws(int index)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());

            Assert.Throws<IndexOutOfRangeException>(() => sut[index] = new FakeDataParameter());
        }

        [Fact]
        public void IndexerSetter_WithValidParameter_SetsParameterAtIndex()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());
            var expected = new FakeDataParameter();
            sut[0] = expected;

            Assert.Same(expected, sut[0]);
        }

        [Fact]
        public void IndexerSetter_WithNonIDataParameterObject_Throws()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());


            Assert.Throws<InvalidCastException>(() => sut[0] = new Object());
        }

        [Fact]
        public void IndexerSetter_WithNull_Throws()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());


            Assert.Throws<ArgumentNullException>(() => sut[0] = null);
        }

        [Theory]
        [InlineData(new object[] { "Dummy" })]
        [InlineData(new object[] { "" })]
        [InlineData(new object[] { null })]
        public void NameIndexerGetter_WithNonExistingParameterName_Throws(string parameterName)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test" });

            Assert.Throws<IndexOutOfRangeException>(() => sut[parameterName]);
        }

        [Theory]
        [InlineData(new object[] { "Dummy" })]
        [InlineData(new object[] { "" })]
        [InlineData(new object[] { null })]
        public void NameIndexerSetter_WithNonExistingParameterName_Throws(string parameterName)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test" });

            Assert.Throws<IndexOutOfRangeException>(() => sut[parameterName] = new FakeDataParameter());
        }

        [Fact]
        public void NameIndexerSetter_WithValidParameter_ReplacesParameter()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test" });
            var expected = new FakeDataParameter() { ParameterName = "Test2" };
            sut["Test"] = expected;

            Assert.Same(expected, sut["Test2"]);
        }

        [Fact]
        public void NameIndexerSetter_WithNonIDataParameterObject_Throws()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test" });

            Assert.Throws<InvalidCastException>(() => sut["Test"] = new Object());
        }

        [Fact]
        public void NameIndexerSetter_WithNull_Throws()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test" });

            Assert.Throws<ArgumentNullException>(() => sut["Test"] = null);
        }

        [Fact]
        public void IsFixedSize_ReturnFalse()
        {
            var sut = new FakeDataParameterCollection();

            Assert.False(sut.IsFixedSize);
        }

        [Fact]
        public void IsReadOnly_ReturnFalse()
        {
            var sut = new FakeDataParameterCollection();

            Assert.False(sut.IsReadOnly);
        }

        [Fact]
        public void IsSynchronized_ReturnFalse()
        {
            var sut = new FakeDataParameterCollection();

            Assert.False(sut.IsSynchronized);
        }

        [Fact]
        public void SyncRoot_ReturnsNonNullObject()
        {
            var sut = new FakeDataParameterCollection();

            Assert.NotNull(sut.SyncRoot);
        }

        [Fact]
        public void SyncRoot_WhenCallesSeveralTimes_ReturnssameNonNullObject()
        {
            var sut = new FakeDataParameterCollection();

            var obj1 = sut.SyncRoot;
            var obj2 = sut.SyncRoot;
            var obj3 = sut.SyncRoot;

            Assert.Same(obj1, sut.SyncRoot);
            Assert.Same(obj2, sut.SyncRoot);
            Assert.Same(obj3, sut.SyncRoot);
        }

        [Fact]
        public void Clear_RemovesAllParametes()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());

            sut.Clear();

            Assert.Equal(0, sut.Count);
        }

        [Fact]
        public void Contains_WithExistingParameter_ReturnsTrue()
        {
            var sut = new FakeDataParameterCollection();
            var parameter = new FakeDataParameter();
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());
            sut.Add(parameter);

            Assert.True(sut.Contains(parameter));
        }

        [Fact]
        public void Contains_WithNonExistingParameter_ReturnsFalse()
        {
            var sut = new FakeDataParameterCollection();
            var parameter = new FakeDataParameter();
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());

            Assert.False(sut.Contains(parameter));
        }

        [Fact]
        public void Contains_WithNull_ReturnsFalse()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());
            sut.Add(new FakeDataParameter());

            Assert.False(sut.Contains(null));
        }

        [Fact]
        public void Contains_WithExistingParameterName_ReturnsTrue()
        {
            var sut = new FakeDataParameterCollection();
            var parameter = new FakeDataParameter() { ParameterName = "Test" };
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(parameter);

            Assert.True(sut.Contains(parameter.ParameterName));
        }

        [Fact]
        public void Contains_WithNonExistingParameterName_ReturnsFalse()
        {
            var sut = new FakeDataParameterCollection();
            var parameter = new FakeDataParameter() { ParameterName = "Test" };
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            Assert.False(sut.Contains(parameter.ParameterName));
        }

        [Fact]
        public void CopyTo_WithNullArray_Throws()
        {
            var sut = new FakeDataParameterCollection();

            Assert.Throws<ArgumentNullException>(() => sut.CopyTo(null, 0));
        }

        [Fact]
        public void CopyTo_WithNegativeIndex_Throws()
        {
            var sut = new FakeDataParameterCollection();

            Assert.Throws<ArgumentOutOfRangeException>(() => sut.CopyTo(new object[1], -1));
        }

        [Theory]
        [MemberData("InvalidArraysFeeder")]
        public void CopyTo_WithInvalidArrays_Throws(Array invalidArray)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            Assert.Throws<ArgumentException>(() => sut.CopyTo(invalidArray, 2));
        }
        public static IEnumerable<object[]> InvalidArraysFeeder
        {
            get
            {
                yield return new object[] { new object[1, 1] };
                yield return new object[] { new object[1] };
                yield return new object[] { new object[4] };
                yield return new object[] { new int[8] };

            }
        }

        [Theory]
        [MemberData("ValidArraysFeeder")]
        public void CopyTo_WithValidParameters_CopiesValuesToArray(Array validArray, int index)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            sut.CopyTo(validArray, index);

            for (int i = 0; i < sut.Count; i++)
            {
                Assert.Same(sut[i], validArray.GetValue(index + i));
            }
        }
        public static IEnumerable<object[]> ValidArraysFeeder
        {
            get
            {
                yield return new object[] { new object[7], 3 };
                yield return new object[] { new object[6], 2 };
                yield return new object[] { new object[5], 1 };
                yield return new object[] { new object[4], 0 };
            }
        }

        [Fact]
        public void GetEnumerator_ReturnsEnumeratorWithAllParameters()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            var enumerator = sut.GetEnumerator();

            enumerator.MoveNext();
            Assert.Same(sut[0], enumerator.Current);
            enumerator.MoveNext();
            Assert.Same(sut[1], enumerator.Current);
            Assert.False(enumerator.MoveNext());
        }

        [Theory]
        [InlineData(new object[] { 0 })]
        [InlineData(new object[] { 1 })]
        [InlineData(new object[] { 2 })]
        public void IndexOf_WithExistingParameter_ReturnsCorrectIndex(int expectedIndex)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            var actualIndex = sut.IndexOf(sut[expectedIndex]);

            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void IndexOf_WithNonExistingParameter_ReturnsCorrectNegativeOne()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            var actualIndex = sut.IndexOf(new FakeDataParameter());

            Assert.Equal(-1, actualIndex);
        }

        [Theory]
        [InlineData(new object[] { "Test1", 0 })]
        [InlineData(new object[] { "Test2", 1 })]
        [InlineData(new object[] { "Test3", 2 })]
        public void IndexOfParameterName_WithExistingParameterName_ReturnsCorrectIndex(string parameterName, int expectedIndex)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            var actualIndex = sut.IndexOf(parameterName);

            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void IndexOfParameterName_WithNonExistingParameterName_ReturnsCorrectNegativeOne()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test4" });

            var actualIndex = sut.IndexOf("NonExistingName");

            Assert.Equal(-1, actualIndex);
        }

        [Fact]
        public void Insert_WithValidParameters_InsertsParameterAtCorrectIndex()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            sut.Insert(1, new FakeDataParameter() { ParameterName = "Inserted" });

            Assert.Equal(0, sut.IndexOf("Test1"));
            Assert.Equal(1, sut.IndexOf("Inserted"));
            Assert.Equal(2, sut.IndexOf("Test2"));
        }

        [Theory]
        [InlineData(new object[] { -1 })]
        [InlineData(new object[] { 3 })]
        public void Insert_WithInvalidIndex_Throws(int invalidIndex)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                sut.Insert(invalidIndex, new FakeDataParameter() { ParameterName = "Inserted" }));
        }

        [Fact]
        public void Insert_WithNullParameter_Throws()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            Assert.Throws<ArgumentNullException>(() => sut.Insert(1, null));
        }

        [Fact]
        public void Insert_WithParameterNotImplementingIDataParameter_Throws()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            Assert.Throws<InvalidCastException>(() => sut.Insert(1, new Object()));
        }


        [Fact]
        public void Remove_WithExistingParameter_RemovesParameter()
        {
            var sut = new FakeDataParameterCollection();
            var paramToRemove = new FakeDataParameter() { ParameterName = "ParamToRemove" };
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(paramToRemove);
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            sut.Remove(paramToRemove);

            Assert.Equal(-1, sut.IndexOf(paramToRemove));
            Assert.Equal(0, sut.IndexOf("Test1"));
            Assert.Equal(1, sut.IndexOf("Test2"));
        }

        [Fact]
        public void Remove_WithNonExistingParameter_DoesNothing()
        {
            var sut = new FakeDataParameterCollection();
            var paramToRemove = new FakeDataParameter() { ParameterName = "ParamToRemove" };
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });

            sut.Remove(paramToRemove);

            Assert.Equal(-1, sut.IndexOf(paramToRemove));
            Assert.Equal(0, sut.IndexOf("Test1"));
            Assert.Equal(1, sut.IndexOf("Test2"));
            Assert.Equal(2, sut.IndexOf("Test3"));
        }

        [Fact]
        public void RemoveAtParameterName_WithExistingParameter_RemovesParameter()
        {
            var sut = new FakeDataParameterCollection();
            var paramToRemove = new FakeDataParameter() { ParameterName = "ParamToRemove" };
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(paramToRemove);
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            sut.RemoveAt("ParamToRemove");

            Assert.Equal(-1, sut.IndexOf("ParamToRemove"));
            Assert.Equal(0, sut.IndexOf("Test1"));
            Assert.Equal(1, sut.IndexOf("Test2"));
        }

        [Fact]
        public void RemoveAtParameterName_WithNonExistingParameter_DoesNothing()
        {
            var sut = new FakeDataParameterCollection();
            var paramToRemove = new FakeDataParameter() { ParameterName = "ParamToRemove" };
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });

            sut.RemoveAt("ParamToRemove");

            Assert.Equal(-1, sut.IndexOf("ParamToRemove"));
            Assert.Equal(0, sut.IndexOf("Test1"));
            Assert.Equal(1, sut.IndexOf("Test2"));
            Assert.Equal(2, sut.IndexOf("Test3"));
        }

        [Fact]
        public void RemoveAt_WithExistingIndex_RemovesParameter()
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test3" });

            sut.RemoveAt(1);

            Assert.Equal(-1, sut.IndexOf("Test2"));
            Assert.Equal(0, sut.IndexOf("Test1"));
            Assert.Equal(1, sut.IndexOf("Test3"));
        }

        [Theory]
        [InlineData(new object[] { -1 })]
        [InlineData(new object[] { 2 })]
        public void RemoveAt_WithInvalidIndex_Throws(int invalidIndex)
        {
            var sut = new FakeDataParameterCollection();
            sut.Add(new FakeDataParameter() { ParameterName = "Test1" });
            sut.Add(new FakeDataParameter() { ParameterName = "Test2" });

            Assert.Throws<ArgumentOutOfRangeException>(() => sut.RemoveAt(invalidIndex));
        }
    }
}

