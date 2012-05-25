
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class TimeLine
	{
		/// <summary>
		/// Gets the collection of entries for the time line
		/// </summary>
		public ICollection<ITimeLineEntry> Entries { get; private set; }
	}
}
