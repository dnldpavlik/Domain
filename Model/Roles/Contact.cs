
namespace DonPavlik.Domain.Model.Roles
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Interfaces;
	using DonPavlik.Domain.Interfaces.Roles;

	/// <summary>
	/// Contact class definition that defines the 
	/// contact role.
	/// </summary>
	public class Contact : PersonRole, IContact
	{
		/// <summary>
		/// Initializes a new instance of the Contact Role
		/// </summary>
		/// <param name="person">Person that is be given contact role</param>
		public Contact(IPerson person)
			: base(person)
		{
			this.Email = string.Empty;
		}

		/// <summary>
		/// Gets or sets the email for the contact
		/// </summary>
		public string Email { get; set; }
	}
}
