
namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Enumerations;

	public interface ITransaction
	{
		/// <summary>
		/// Gets or sets the description of the 
		/// transaction
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// Gets or sets the amount of the transaction
		/// </summary>
		double Amount { get; set; }

		/// <summary>
		/// Gets or set the date of the transaction
		/// </summary>
		DateTime Date { get; set; }

		/// <summary>
		/// Gets or sets the transaction type of the 
		/// transaction
		/// </summary>
		TransactionTypes TransactionType { get; set; }

		/// <summary>
		/// Gets the collection of tags that are on the 
		/// transaction
		/// </summary>
		ICollection<string> Tags { get; }

		/// <summary>
		/// Gets or sets the account for this transaction
		/// </summary>
		IAccount Account { get; set; }
	}
}
