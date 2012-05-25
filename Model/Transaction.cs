
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using DonPavlik.Domain.Enumerations;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Transaction class definition
	/// </summary>
	public class Transaction : ITransaction
	{
		/// <summary>
		/// Initializes an instance of the transaction
		/// class
		/// </summary>
		public Transaction()
		{
			this.Description = string.Empty;
			this.Tags = new Collection<string>();
		}
		
		/// <summary>
		/// Gets or sets the description of the 
		/// transaction
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the amount of the transaction
		/// </summary>
		public double Amount { get; set; }

		/// <summary>
		/// Gets or set the date of the transaction
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Gets or sets the transaction type of the 
		/// transaction
		/// </summary>
		public TransactionTypes TransactionType { get; set; }

		/// <summary>
		/// Gets the collection of tags that are on the 
		/// transaction
		/// </summary>
		public ICollection<string> Tags { get; private set; }

		/// <summary>
		/// Gets or sets the account for this transaction
		/// </summary>
		public IAccount Account { get; set; }
	}
}
