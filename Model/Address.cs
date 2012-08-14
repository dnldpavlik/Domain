
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Attributes;
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
		}

		/// <summary>
		/// Initializes an instance of Address class with the string address provided
		/// </summary>
		/// <param name="address"></param>
		public Address ( string address )
			: this()
		{
		  if(address.Contains(','))
		  {
			string[] addressParts = address.Split(',');
			this.Street = addressParts[0].Trim();
			this.City = addressParts[1].Trim();

			if(addressParts.Length == 3)
			{
				string[] stateZip = addressParts[2].Trim().Split(' ');

				if(RegEXPatterns.MatchFound(stateZip.Last(), RegEXPatterns.ZIP_CODE))
				{
					this.Zip = stateZip.Last();
					this.State = addressParts[2].Replace(this.Zip, string.Empty).Trim();
				}
				else
				{
					this.State = addressParts[2].Trim();
				}
			}
		  }
		  else
		  {
			this.Street = address;
		  }
		  
		  // TODO: parsing code for assigning Local properties from a single sting
		  // street, city, state zip
		  // city, state zip
		  // state zip
		  // street 1, street 2, city, state zip
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
		[RegularExpressionAttribute(RegEXPatterns.ZIP_CODE)]
		public string Zip { get; set; }
	}
}
