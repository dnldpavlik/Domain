
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
	/// Time Line Class definition for working with Time Lines
	/// </summary>
	public class TimeLine : ITimeLine
	{
		/// <summary>
		/// Initializes a new instance of the TimeLine Class
		/// </summary>
		public TimeLine()
		{
			this.Entries = new Collection<ITimeLineEntry>();
		}

		/// <summary>
		/// Gets the collection of entries for the time line
		/// </summary>
		public ICollection<ITimeLineEntry> Entries { get; private set; }
	}
}
