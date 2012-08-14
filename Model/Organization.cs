
namespace DonPavlik.Domain.Model
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using DonPavlik.Domain.Interfaces;

	///<summary>
	/// Organization class definition for dealing with organizations and it's relationships
	///</summary>
	public class Organization : IOrganization
	{
		///<summary>
		/// Initializes a new instance of the organization class
		///</summary>
		public Organization()
		{
			this.Name = string.Empty;
			this.Members = new Collection<IPerson>();
		}

		///<summary>
		/// Gets or sets the address for the organization.
		///</summary>
		public IAddress Address { get; set; }

		///<summary>
		/// Gets or sets the name of the organization
		///</summary>
		public string Name { get; set; }

		///<summary>
		/// Gets the collection of Members that belong to the organization
		///</summary>
		public ICollection<IPerson> Members { get; private set; }
	}
}