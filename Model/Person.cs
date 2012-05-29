
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Person class for dealing with people
	/// </summary>
	public class Person : IPerson
	{
		/// <summary>
		/// Initializes an instance of the Person Class
		/// </summary>
		public Person()
		{
			this.Aliases = new Dictionary<string, IAnthroponym>();
			this.Gender  = string.Empty;
		}

		/// <summary>
		/// Gets or sets the Date of Birth for the person
		/// </summary>
		public DateTime? DateOfBirth { get; set; }

		/// <summary>
		/// Gets or sets the Date of death for the person
		/// </summary>
		public DateTime? DateOfDeath { get; set; }

		/// <summary>
		/// Gets or sets the gender of the person
		/// </summary>
		public string Gender { get; set; }

		/// <summary>
		/// Gets the Primary name of the person
		/// </summary>
		public IAnthroponym PrimaryName
		{
			get; 
			private set;
		}

		/// <summary>
		/// Gets the list of Aliases for the person
		/// </summary>
		public IDictionary<string, IAnthroponym> Aliases
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the time line for this person
		/// </summary>
		public ITimeLine TimeLine { get; private set; }

		/// <summary>
		/// Gets or sets the Address for the person
		/// </summary>
		public IAddress Address { get; set; }
	}
}
