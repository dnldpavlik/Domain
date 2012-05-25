
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class AccountTests
	{
		/// <summary>
		/// Test that an initialized account has an empty name
		/// </summary>
		[TestMethod]
		public void InitializedAccountHasEmptyName()
		{
			Account account = new Account();

			Assert.AreEqual(string.Empty, account.Name);
		}

		/// <summary>
		/// Tests that an initialized account has no transactions
		/// </summary>
		[TestMethod]
		public void InitializedAcocuntHasZeroTransactions()
		{
			Account account = new Account();

			Assert.AreEqual(0, account.Transactions.Count);
		}

		/// <summary>
		/// Tests that an initialized account has a balance of zero
		/// </summary>
		[TestMethod]
		public void InitializedAccountHasZeroBalance()
		{
			Account account = new Account();

			Assert.AreEqual(0.0, account.Balance);
		}

		/// <summary>
		/// Tests that an initialized account's calculated balance
		/// is zero
		/// </summary>
		[TestMethod]
		public void InitializedAccountCalculatedBalanceZero()
		{
			Account account = new Account();

			Assert.AreEqual(0.0, account.CalculateBalance());
		}

		/// <summary>
		/// Tests an account that has an initial deposite has the same amount as
		/// the deposited amount
		/// </summary>
		[TestMethod]
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

			Assert.AreEqual(initialAmount, account.CalculateBalance());
		}

		/// <summary>
		/// Tests an account with a zero balance that has a transaction type
		/// of withdrawal has a negative balance.
		/// </summary>
		[TestMethod]
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

			Assert.AreEqual(-withdrawalAmount, account.CalculateBalance());
		}

		/// <summary>
		/// Tests an account that has had its balance calculated is the same value 
		/// that the calculation returned.
		/// </summary>
		[TestMethod]
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

			Assert.AreEqual(account.CalculateBalance(), account.Balance);
		}
	}
}
