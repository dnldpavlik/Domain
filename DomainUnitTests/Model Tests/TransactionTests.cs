
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Enumerations;
	using DonPavlik.Domain.Model;
	using Xunit;

	/// <summary>
	/// Tests for the transaction model class
	/// </summary>
	public class TransactionTests
	{
		/// <summary>
		/// Tests that an initialized transaction has an 
		/// empty description
		/// </summary>
		[Fact]
		public void InitializedTransactionDescriptionEmpty()
		{
			Transaction transaction = new Transaction();

			Assert.Equal(string.Empty, transaction.Description);
		}

		/// <summary>
		/// Tests that an initialized transaction has an 
		/// amount of zero
		/// </summary>
		[Fact]
		public void InitializedTransactionAmountZero()
		{
			Transaction transaction = new Transaction();

			Assert.Equal(transaction.Amount, 0.0);
		}

		/// <summary>
		/// Tests that an initialized transaction has its date
		/// value as the min date time value
		/// </summary>
		[Fact]
		public void InitializedTransactionDateIsDateMin()
		{
			Transaction transaction = new Transaction();

			Assert.Equal(transaction.Date, DateTime.MinValue);
		}

		/// <summary>
		/// Tests that an initialized transaction has its 
		/// transaction type set to withdrawal
		/// </summary>
		[Fact]
		public void InitializedTransactionTransactionTypeNotSet()
		{
			Transaction transaction = new Transaction();

			Assert.Equal(transaction.TransactionType, TransactionTypes.Withdrawal);
		}

		/// <summary>
		/// Tests that an initialized transaction's tag collection
		/// has a count/length of zero
		/// </summary>
		[Fact]
		public void InitializedTransactionTagsLengthZero()
		{
			Transaction transaction = new Transaction();

			Assert.Equal(0, transaction.Tags.Count);
		}
		
		/// <summary>
		/// Tests that an initialized transaction's account is null 
		/// </summary>
		[Fact]
		public void InitializedTransactionHasNullAccount()
		{
			Transaction transaction = new Transaction();

			Assert.Null(transaction.Account);
		}
	}
}
