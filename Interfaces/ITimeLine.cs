
namespace DonPavlik.Domain.Interfaces
{
	using System.Collections.Generic;

	/// <summary>
	/// Interface for Time Line Definition
	/// </summary>
	public interface ITimeLine
	{
		/// <summary>
		/// Gets the collection of entries for the time line
		/// </summary>
		ICollection<ITimeLineEntry> Entries { get; }
	}
}
