
namespace DonPavlik.Domain.Model
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Account class definition for dealing with Finacial accounts
	/// </summary>
	public class Account : IAccount
	{
		/// <summary>
		/// Initializes an instance of the Account Class
		/// </summary>
		public Account()
		{
			this.Name = string.Empty;
			this.Transactions = new Collection<ITransaction>();
		}
		
		/// <summary>
		/// Gets or sets the name of the account
		/// </summary>
		public string Name
		{
			get; set;
		}

		/// <summary>
		/// Gets the collection of transactions for this account
		/// </summary>
		public ICollection<ITransaction> Transactions
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the balance for this account
		/// </summary>
		public double Balance
		{
			get;
			private set;
		}

		/// <summary>
		/// Calculates the balance for the account by going through the
		/// collection of transactions then sets the Balance of the account
		/// and finaly returns the balance.
		/// </summary>
		/// <returns>Returns the balance calculated</returns>
		public double CalculateBalance()
		{	
			double balance = 0.0;

			foreach(Transaction transaction in this.Transactions)
			{
				if (transaction.TransactionType == Enumerations.TransactionTypes.Desposit)
				{
					balance += transaction.Amount;
				}
				else
				{
					balance -= transaction.Amount;
				}
			}

			this.Balance = balance;
			return this.Balance;
		}
	}
}
