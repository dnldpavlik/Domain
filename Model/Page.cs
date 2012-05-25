
namespace DonPavlik.Domain.Model
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Page class definition that represents a file
	/// </summary>
	public class Page : IPage
	{
		/// <summary>
		/// Creates an instance of a Page.
		/// </summary>
		public Page()
		{
			this.Lines = new Collection<ILine>();
			this.MetaData = new Dictionary<string,object>();
			this.Name = string.Empty;
			this.FilePath = string.Empty;
		}

		/// <summary>
		/// Gets a collection of lines in a file
		/// </summary>
		public ICollection<ILine> Lines
		{
			get; 
			private set;
		}

		/// <summary>
		/// Gets the Metadata defined for a file
		/// </summary>
		public Dictionary<string, object> MetaData
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets or sets the name of the page
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the file path for the page
		/// </summary>
		public string FilePath
		{
			get;
			set;
		}
	}
}
