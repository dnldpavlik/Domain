
namespace DonPavlik.Domain.Model
{
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Anthroponym class for dealing with a persons name, inherits from IAnthroponym
	/// </summary>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Anthroponym")]
	public class Anthroponym : IAnthroponym
	{
		public string FullName
		{
			get 
			{
				string fullName = this.Prefix;
				fullName = fullName.Trim() + this.Given;
				fullName = fullName.Trim() + this.Middle;
				fullName = fullName.Trim() + this.Surname;
				fullName = fullName.Trim() + this.Suffix;

				return fullName.Trim();
			}
		}

		public string Given
		{
			get; set;
		}

		public string Middle
		{
			get; set;
		}

		public string Surname
		{
			get; set;
		}

		public string Suffix
		{
			get; set;
		}

		public string Prefix
		{
			get; set;
		}
	}
}
