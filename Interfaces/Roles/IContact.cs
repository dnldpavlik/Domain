
namespace DonPavlik.Domain.Interfaces.Roles
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Contact interface definition
	/// </summary>
	public interface IContact : IPerson
	{
		/// <summary>
		/// Gets or sets the email for the contact
		/// </summary>
		string Email { get; set; }
	}
}
