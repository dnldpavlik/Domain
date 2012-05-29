
namespace DonPavlik.Domain.Model
{
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Anthroponym class for dealing with a persons name, inherits from IAnthroponym
	/// </summary>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Anthroponym")]
	public class Anthroponym : IAnthroponym
	{
		/// <summary>
		/// Initializes a new instance of Anthroponym Class
		/// </summary>
		public Anthroponym()
		{
			this.Given = string.Empty;
			this.Middle = string.Empty;
			this.Surname = string.Empty;
			this.Suffix = string.Empty;
			this.Prefix = string.Empty;
		}

		/// <summary>
		/// Gets the full name of the Anthroponym
		/// </summary>
		public string FullName
		{
			get 
			{
				string fullName = string.Empty;

				if (!string.IsNullOrWhiteSpace(this.Prefix))
				{
					fullName += this.Prefix + " ";
				}

				if (!string.IsNullOrWhiteSpace(this.Given))
				{
					fullName += this.Given + " ";
				}

				if (!string.IsNullOrWhiteSpace(this.Middle))
				{
					fullName += this.Middle + " ";
				}

				if (!string.IsNullOrWhiteSpace(this.Surname))
				{
					fullName += this.Surname + " ";
				}

				if (!string.IsNullOrWhiteSpace(this.Suffix))
				{
					fullName += this.Suffix;
				}

				return fullName.Trim();
			}
		}

		/// <summary>
		/// Gets or sets the Given name of the Anthroponym, also
		/// known as the first name of a person
		/// </summary>
		public string Given
		{
			get; set;
		}

		/// <summary>
		/// Gets or sets the Middle name of the Anthroponym
		/// </summary>
		public string Middle
		{
			get; set;
		}

		/// <summary>
		/// Gets or sets the Surname of the Anthroponym
		/// </summary>
		public string Surname
		{
			get; set;
		}

		/// <summary>
		/// Gets or sets the Suffix of the Anthroponym
		/// </summary>
		public string Suffix
		{
			get; set;
		}

		/// <summary>
		/// Gets or sets the Prefix of the Anthroponym
		/// </summary>
		public string Prefix
		{
			get; set;
		}
	}
}
