
namespace DonPavlik.Domain.Interfaces
{
	using System.Collections.Generic;

	/// <summary>
	/// Task Interface definition for dealing with tasks
	/// </summary>
	public interface ITask
	{
		/// <summary>
		/// Gets or sets a value that indecates if the task has been
		/// flagged
		/// </summary>
		bool Flagged { get; set; }

		/// <summary>
		/// Gets or sets whether a task is completed
		/// </summary>
		bool IsCompleted { get; set; }		

		/// <summary>
		/// Gets or sets the note on the task
		/// </summary>
		string Note { get; set; }

		/// <summary>
		/// Gets or sets the project that this task belongs to
		/// </summary>
		IProject Project { get; set; }
		
		/// <summary>
		/// Gets or sets the summary for this task
		/// </summary>
		string Summary { get; set; }

		/// <summary>
		/// Gets the description of the task that has been identified to be completed.
		/// </summary>
		string TaskDescription { get; }

		/// <summary>
		/// Gets the list of sub tasks for this task
		/// </summary>
		ICollection<ITask> Tasks { get; }
	}
}
