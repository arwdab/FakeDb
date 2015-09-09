using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FakeDb.Tests
{
    public class FakeDbTransactionTests
    {
        [Fact]
        public void Constructor_WithNullConnection_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => new FakeDbTransaction(null));
        }

        [Fact]
        public void Constructor_WithoutIsolationLevel_ConnectionIsSameAsInParameter()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection);

            Assert.Same(connection, sut.Connection);
        }

        [Fact]
        public void Constructor_WithoutIsolationLevel_IsolationLevelIsSetToDefaultValue()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection);

            Assert.Equal<IsolationLevel>(IsolationLevel.ReadCommitted, sut.IsolationLevel);
        }

        [Fact]
        public void Constructor_WithIsolationLevel_ConnectionIsSameAsInParameter()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection, IsolationLevel.Unspecified);

            Assert.Same(connection, sut.Connection);
        }

        [Fact]
        public void Constructor_WithIsolationLevel_IsolationLevelEqualsInParameter()
        {
            var expected = IsolationLevel.RepeatableRead;
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection, expected);

            Assert.Equal<IsolationLevel>(expected, sut.IsolationLevel);
        }

        [Fact]
        public void Commit_OnCommitedTransaction_Throws()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection);
            sut.Commit();

            Assert.Throws<InvalidOperationException>(() => sut.Commit());
        }

        [Fact]
        public void Commit_OnRollbackedTransaction_Throws()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection);
            sut.Rollback();

            Assert.Throws<InvalidOperationException>(() => sut.Commit());
        }

        [Fact]
        public void Rollback_OnCommitedTransaction_Throws()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection);
            sut.Commit();

            Assert.Throws<InvalidOperationException>(() => sut.Rollback());
        }

        [Fact]
        public void Rollback_OnRollbackedTransaction_Throws()
        {
            var connection = new FakeDbConnection();
            var sut = new FakeDbTransaction(connection);
            sut.Rollback();

            Assert.Throws<InvalidOperationException>(() => sut.Rollback());
        }
    }
}
