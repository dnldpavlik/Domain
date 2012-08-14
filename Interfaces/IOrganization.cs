
namespace DonPavlik.Domain.Interfaces
{
	using System.Collections.Generic;

	public interface IOrganization
	{
		///<summary>
		/// Gets or sets the address for the organization.
		///</summary>
		IAddress Address { get; set; }

		///<summary>
		/// Gets or sets the name of the organization
		///</summary>
		string Name { get; set; }

		///<summary>
		/// Gets the collection of Members that belong to the organization
		///</summary>
		ICollection<IPerson> Members { get; }
	}
}
