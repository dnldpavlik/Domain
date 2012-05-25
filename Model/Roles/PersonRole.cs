
namespace DonPavlik.Domain.Model.Roles
{
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Person Role Class definition for the Roles Decoratore
	/// </summary>
	public abstract class PersonRole : Person
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
	}
}
