
namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Person interface for dealing with people
	/// </summary>
	public interface IPerson
	{
		/// <summary>
		/// Gets or sets the Date of Death
		/// </summary>
		DateTime? DateOfDeath { get; set; }

		/// <summary>
		/// Gets or sets the date of birth
		/// </summary>
		DateTime DateOfBirth { get; set; }

		/// <summary>
		/// Gets or sets the Gender for the person
		/// </summary>
		string Gender { get; set; }

		/// <summary>
		/// Gets the Primary name of the person
		/// </summary>
		IAnthroponym PrimaryName { get; }

		/// <summary>
		/// Gest the List of name aliases for a person
		/// </summary>
		IDictionary<string, IAnthroponym> Aliases { get; }
	}
}
