
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Enumerations;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	/// <summary>
	/// Tests for the transaction model class
	/// </summary>
	[TestClass]
	public class TransactionTests
	{
		/// <summary>
		/// Tests that an initialized transaction has an 
		/// empty description
		/// </summary>
		[TestMethod]
		public void InitializedTransactionDescriptionEmpty()
		{
			Transaction transaction = new Transaction();

			Assert.AreEqual(string.Empty, transaction.Description);
		}

		/// <summary>
		/// Tests that an initialized transaction has an 
		/// amount of zero
		/// </summary>
		[TestMethod]
		public void InitializedTransactionAmountZero()
		{
			Transaction transaction = new Transaction();

			Assert.AreEqual(transaction.Amount, 0.0);
		}

		/// <summary>
		/// Tests that an initialized transaction has its date
		/// value as the min date time value
		/// </summary>
		[TestMethod]
		public void InitializedTransactionDateIsDateMin()
		{
			Transaction transaction = new Transaction();

			Assert.AreEqual(transaction.Date, DateTime.MinValue);
		}

		/// <summary>
		/// Tests that an initialized transaction has its 
		/// transaction type set to withdrawal
		/// </summary>
		[TestMethod]
		public void InitializedTransactionTransactionTypeNotSet()
		{
			Transaction transaction = new Transaction();

			Assert.AreEqual(transaction.TransactionType, TransactionTypes.Withdrawal);
		}

		/// <summary>
		/// Tests that an initialized transaction's tag collection
		/// has a count/length of zero
		/// </summary>
		[TestMethod]
		public void InitializedTransactionTagsLengthZero()
		{
			Transaction transaction = new Transaction();

			Assert.AreEqual(0, transaction.Tags.Count);
		}
		
		/// <summary>
		/// Tests that an initialized transaction's account is null 
		/// </summary>
		[TestMethod]
		public void InitializedTransactionHasNullAccount()
		{
			Transaction transaction = new Transaction();

			Assert.IsNull(transaction.Account);
		}
	}
}
