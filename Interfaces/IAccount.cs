
namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;
	using DonPavlik.Domain.Model;

	/// <summary>
	/// Defines the interface for Account
	/// </summary>
	public interface IAccount
	{
		/// <summary>
		/// Gets the balance for this account
		/// </summary>
		double Balance { get; }

		/// <summary>
		/// Calculates the balance for the account by going through the
		/// collection of transactions then sets the Balance of the account
		/// and finaly returns the balance.
		/// </summary>
		/// <returns>Returns the balance calculated</returns>
		double CalculateBalance();

		/// <summary>
		/// Gets or sets the name of the account
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Gets the collection of transactions for this account
		/// </summary>
		ICollection<ITransaction> Transactions { get; }
	}
}
