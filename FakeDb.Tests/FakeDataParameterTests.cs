using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace FakeDb.Tests
{
    public class FakeDataParameterTests
    {
        [Fact]
        public void DbType_Getter_ReturnsDefautValue()
        {
            var sut = new FakeDataParameter();

            Assert.Equal<DbType>(DbType.String, sut.DbType);
        }

        [Theory]
        [MemberData("ValidDbTypes")]
        public void DbType_SetterWithValidValues_GetterReturnsSetValue(DbType dbType)
        {
            var sut = new FakeDataParameter();

            sut.DbType = dbType;

            Assert.Equal<DbType>(dbType, sut.DbType);
        }
        public static IEnumerable<object[]> ValidDbTypes
        {
            get
            {
                foreach (var value in Enum.GetValues(typeof(DbType)))
                {
                    yield return new object[] { value };
                }
            }
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("100")]
        public void DbType_SetterWithInvalidValue_Throws(string invalidValue)
        {
            var sut = new FakeDataParameter();

            Assert.Throws<ArgumentOutOfRangeException>(() => sut.DbType = (DbType)Enum.Parse(typeof(DbType), invalidValue));
        }

        [Fact]
        public void Direction_Getter_ReturnsDefautValue()
        {
            var sut = new FakeDataParameter();

            Assert.Equal<ParameterDirection>(ParameterDirection.Input, sut.Direction);
        }

        [Theory]
        [MemberData("ValidDirections")]
        public void Direction_SetterWithValidValues_GetterReturnsSetValue(ParameterDirection direction)
        {
            var sut = new FakeDataParameter();

            sut.Direction = direction;

            Assert.Equal<ParameterDirection>(direction, sut.Direction);
        }
        public static IEnumerable<object[]> ValidDirections
        {
            get
            {
                foreach (var value in Enum.GetValues(typeof(ParameterDirection)))
                {
                    yield return new object[] { value };
                }
            }
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("100")]
        public void Direction_SetterWithInvalidValue_Throws(string invalidValue)
        {
            var sut = new FakeDataParameter();

            Assert.Throws<ArgumentException>(() => sut.Direction = (ParameterDirection)Enum.Parse(typeof(ParameterDirection), invalidValue));
        }

        [Fact]
        public void IsNullable_ReturnsDefaultValue()
        {
            var sut = new FakeDataParameter();

            Assert.False(sut.IsNullable);
        }

        [Fact]
        public void ParameterName_ReturnsDefaultValue()
        {
            var sut = new FakeDataParameter();

            Assert.Equal<string>("", sut.ParameterName);
        }

        [Fact]
        public void SourceColumn_ReturnsDefaultValue()
        {
            var sut = new FakeDataParameter();

            Assert.Equal<string>("", sut.SourceColumn);
        }

        [Fact]
        public void SourceVersion_Getter_ReturnsDefautValue()
        {
            var sut = new FakeDataParameter();

            Assert.Equal<DataRowVersion>(DataRowVersion.Current, sut.SourceVersion);
        }

        [Theory]
        [MemberData("ValidDataRowVersions")]
        public void SourceVersion_SetterWithValidValues_GetterReturnsSetValue(DataRowVersion rowVersion)
        {
            var sut = new FakeDataParameter();

            sut.SourceVersion = rowVersion;

            Assert.Equal<DataRowVersion>(rowVersion, sut.SourceVersion);
        }
        public static IEnumerable<object[]> ValidDataRowVersions
        {
            get
            {
                foreach (var value in Enum.GetValues(typeof(DataRowVersion)))
                {
                    yield return new object[] { value };
                }
            }
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("100")]
        public void SourceVersion_SetterWithInvalidValue_Throws(string invalidValue)
        {
            var sut = new FakeDataParameter();

            Assert.Throws<ArgumentException>(() => sut.SourceVersion = (DataRowVersion)Enum.Parse(typeof(DataRowVersion), invalidValue));
        }

        [Fact]
        public void Value_ReturnsDefaultValue()
        {
            var sut = new FakeDataParameter();

            Assert.Equal<object>(null, sut.Value);
        }
    }
}
