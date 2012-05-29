
namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IAddress
	{
		/// <summary>
		/// Gets or sets the street for the Address
		/// </summary>
		string Street { get; set; }

		/// <summary>
		/// Gets or sets the city for the Address
		/// </summary>
		string City { get; set; }

		/// <summary>
		/// Gets or sets the state for the Address
		/// </summary>
		string State { get; set; }

		/// <summary>
		/// Gets or sets the Zip for the address
		/// </summary>
		string Zip { get; set; }
	}
}
