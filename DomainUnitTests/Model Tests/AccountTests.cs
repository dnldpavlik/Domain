
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class AccountTests
	{
		/// <summary>
		/// Test that an initialized account has an empty name
		/// </summary>
		[Fact]
		public void InitializedAccountHasEmptyName()
		{
			Account account = new Account();

			Assert.Equal(string.Empty, account.Name);
		}

		/// <summary>
		/// Tests that an initialized account has no transactions
		/// </summary>
		[Fact]
		public void InitializedAcocuntHasZeroTransactions()
		{
			Account account = new Account();

			Assert.Equal(0, account.Transactions.Count);
		}

		/// <summary>
		/// Tests that an initialized account has a balance of zero
		/// </summary>
		[Fact]
		public void InitializedAccountHasZeroBalance()
		{
			Account account = new Account();

			Assert.Equal(0.0, account.Balance);
		}

		/// <summary>
		/// Tests that an initialized account's calculated balance
		/// is zero
		/// </summary>
		[Fact]
		public void InitializedAccountCalculatedBalanceZero()
		{
			Account account = new Account();

			Assert.Equal(0.0, account.CalculateBalance());
		}

		/// <summary>
		/// Tests an account that has an initial deposite has the same amount as
		/// the deposited amount
		/// </summary>
		[Fact]
		public void AccountWithInitialTransactionOfDepositeBalanceIsTransactionAmount()
		{
			double initialAmount = 15.0;
			Account account = new Account();
			account.Transactions.Add(
				new Transaction
				{
					Amount = initialAmount,
					TransactionType = Enumerations.TransactionTypes.Desposit
				});

			Assert.Equal(initialAmount, account.CalculateBalance());
		}

		/// <summary>
		/// Tests an account with a zero balance that has a transaction type
		/// of withdrawal has a negative balance.
		/// </summary>
		[Fact]
		public void AccountWithZeroBalanceWithWidthDrawalIsNegativeBalance()
		{
			double withdrawalAmount = 15;
			Account account = new Account();
			account.Transactions.Add(
				new Transaction
				{
					Amount = withdrawalAmount,
					TransactionType = Enumerations.TransactionTypes.Withdrawal
				});

			Assert.Equal(-withdrawalAmount, account.CalculateBalance());
		}

		/// <summary>
		/// Tests an account that has had its balance calculated is the same value 
		/// that the calculation returned.
		/// </summary>
		[Fact]
		public void AccountsBalanceIsCalculatedAmount()
		{
			double initialAmount = 15.0;
			Account account = new Account();
			account.Transactions.Add(
				new Transaction
				{
					Amount = initialAmount,
					TransactionType = Enumerations.TransactionTypes.Desposit
				});

			Assert.Equal(account.CalculateBalance(), account.Balance);
		}
	}
}
