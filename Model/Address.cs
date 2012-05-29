
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Address Class definition
	/// </summary>
	public class Address : IAddress
	{
		/// <summary>
		/// Initializes an instance of Address class
		/// </summary>
		public Address()
		{
			this.Street = string.Empty;
			this.City   = string.Empty;
			this.State  = string.Empty;
			this.Zip    = string.Empty;
		}

		/// <summary>
		/// Gets or sets the street for the Address
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// Gets or sets the city for the Address
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Gets or sets the state for the Address
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// Gets or sets the Zip for the address
		/// </summary>
		public string Zip { get; set; }
	}
}
