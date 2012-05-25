
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Time Line Entry class definition for defining time line entries
	/// </summary>
	public class TimeLineEntry : ITimeLineEntry
	{
		/// <summary>
		/// Initializes an instance of TimeLineEntry Class
		/// </summary>
		public TimeLineEntry()
		{
			this.Title = string.Empty;
			this.Entry = new Collection<ILine>();
		}

		/// <summary>
		/// Gets or sets the title of the time line entry
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the date time of the time line entry
		/// </summary>
		public DateTime DateTime { get; set; }

		/// <summary>
		/// Gets the entry of the time line entry as a collection of lines
		/// </summary>
		public ICollection<ILine> Entry { get; private set; }
	}
}
