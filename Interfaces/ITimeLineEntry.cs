
namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface ITimeLineEntry
	{
		/// <summary>
		/// Gets or sets the title of the time line entry
		/// </summary>
		string Title { get; set; }

		/// <summary>
		/// Gets or sets the date time of the time line entry
		/// </summary>
		DateTime DateTime { get; set; }

		/// <summary>
		/// Gets the entry of the time line entry as a collection of lines
		/// </summary>
		ICollection<ILine> Entry { get; }
	}
}
