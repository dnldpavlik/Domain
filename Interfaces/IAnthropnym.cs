
namespace DonPavlik.Domain.Interfaces
{
	/// <summary>
	/// Anthroponym interface for dealing with a persons name
	/// </summary>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Anthroponym")]
	public interface IAnthroponym
	{
		/// <summary>
		/// Gets the full name
		/// </summary>
		string FullName { get; set; }

		/// <summary>
		/// Gets or sets the Given name, also known as first name
		/// </summary>
		string Given { get; set; }

		/// <summary>
		/// Gets or sets the Middle name
		/// </summary>
		string Middle { get; set; }

		/// <summary>
		/// Gets or sets the Surname, also known as last name
		/// </summary>
		string Surname { get; set; }

		/// <summary>
		/// Gets or sets the suffix
		/// </summary>
		string Suffix { get; set; }

		/// <summary>
		/// Gets or sets the prefix
		/// </summary>
		string Prefix { get; set; }
	}
}