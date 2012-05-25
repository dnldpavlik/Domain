
namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Defines the Page Interface
	/// </summary>
	public interface IPage
	{
		/// <summary>
		/// Gets or sets the file path for the page
		/// </summary>
		string FilePath { get; set; }

		/// <summary>
		/// Gets a collection of lines in a file
		/// </summary>
		ICollection<ILine> Lines { get; }

		/// <summary>
		/// Gets the Metadata defined for a file
		/// </summary>
		Dictionary<string, object> MetaData { get; }

		/// <summary>
		/// Gets or sets the name of the page
		/// </summary>
		string Name { get; set; }
	}
}
