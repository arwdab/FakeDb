using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data.SqlClient;

namespace FakeDb.Tests
{
    public class FakeDbConnectionTests
    {
        [Fact]
        public void ConnectionTimeout_Getter_ReturnsDefaultValue()
        {
            var sut = new FakeDbConnection();

            Assert.Equal<int>(15, sut.ConnectionTimeout);
        }

        [Fact]
        public void Database_Getter_ReturnsDefaultValue()
        {
            var sut = new FakeDbConnection();

            Assert.Equal<string>("", sut.Database);
        }

        [Fact]
        public void ConnectionString_Getter_ReturnsDefaultValue()
        {
            var sut = new FakeDbConnection();

            Assert.Equal<string>("", sut.ConnectionString);
        }


        [Fact]
        public void ConnectionState_Getter_ReturnsDefaultValue()
        {
            var sut = new FakeDbConnection();

            Assert.Equal<ConnectionState>(ConnectionState.Closed, sut.State);
        }

        [Fact]
        public void Open_StateIsSetToOpen()
        {
            var sut = new FakeDbConnection();

            sut.Open();

            Assert.Equal<ConnectionState>(ConnectionState.Open, sut.State);
        }

        [Fact]
        public void ChangeDatabase_WhenStateIsClosed_Throws()
        {
            var sut = new FakeDbConnection();

            Assert.Throws<InvalidOperationException>(() => sut.ChangeDatabase("dummy"));
        }

        [Fact]
        public void ChangeDatabase_WhenStateIsOpen_SetsDatabaseProperty()
        {
            var sut = new FakeDbConnection();
            sut.Open();

            sut.ChangeDatabase("dummy");

            Assert.Equal<string>("dummy", sut.Database);
        }

        [Fact]
        public void Close_WhenStateIsOpen_SetsStateToClosed()
        {
            var sut = new FakeDbConnection();
            sut.Open();

            sut.Close();

            Assert.Equal<ConnectionState>(ConnectionState.Closed, sut.State);
        }
    }
}
