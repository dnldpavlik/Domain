
namespace DonPavlik.Domain.Model.Roles
{
	using System.Collections.Generic;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Person Role Class definition for the Roles Decoratore
	/// </summary>
	public abstract class PersonRole : IPerson
	{
		/// <summary>
		/// Protected reference to person that is being decorated
		/// </summary>
		protected IPerson _person;

		/// <summary>
		/// Initializes an instance of Person Role, for the person
		/// that is being passed in.
		/// </summary>
		/// <param name="person">Person that is to be decorated</param>
		public PersonRole(IPerson person)
		{
			this._person = person;
		}

		/// <summary>
		/// Gets or sets the Death date for the person
		/// </summary>
		public System.DateTime? DateOfDeath
		{
			get
			{
				return this._person.DateOfDeath;
			}
			set
			{
				this._person.DateOfDeath = value;
			}
		}

		/// <summary>
		/// Gets or sets the Birth date of the person
		/// </summary>
		public System.DateTime? DateOfBirth
		{
			get
			{
				return this._person.DateOfBirth;
			}
			set
			{
				this._person.DateOfBirth = value;
			}
		}

		/// <summary>
		/// Gets or sets the gender for the person
		/// </summary>
		public string Gender
		{
			get
			{
				return this._person.Gender;
			}
			set
			{
				this._person.Gender = value;
			}
		}

		/// <summary>
		/// Gets the primary name for the person
		/// </summary>
		public IAnthroponym PrimaryName
		{
			get { return this._person.PrimaryName; }
		}

		/// <summary>
		/// Gets the collection of Aliases for the person
		/// </summary>
		public IDictionary<string, IAnthroponym> Aliases
		{
			get { return this._person.Aliases; }
		}

		/// <summary>
		/// Gets the time line for the person
		/// </summary>
		public ITimeLine TimeLine
		{
			get { return this._person.TimeLine; }
		}

		/// <summary>
		/// Gets or sets the address for a person
		/// </summary>
		public IAddress Address
		{
			get
			{
				return this._person.Address;
			}
			set
			{
				this._person.Address = value;
			}
		}

		/// <summary>
		/// Gets or sets the image for this contact
		/// </summary>
		public string Image
		{
			get
			{
				return this._person.Image;
			}
			set
			{
				this._person.Image = value;
			}
		}
	}
}
