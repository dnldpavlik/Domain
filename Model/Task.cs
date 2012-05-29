
namespace DonPavlik.Domain.Model
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Task definition for dealing with tasks
	/// </summary>
	public class Task : ITask
	{
		/// <summary>
		/// Intializes an instance of Task Class
		/// </summary>
		public Task()
		{
			this.Tasks = new HashSet<ITask>();
			this.TaskDescription = string.Empty;
			this.Note = string.Empty;
			this.Summary = string.Empty;
		}

		/// <summary>
		/// Intializes an instance of Task Class
		/// </summary>
		/// <param name="task"></param>
		public Task(string task)
			: this()
		{
			this.TaskDescription = task;
		}

		#region Public Properties

		/// <summary>
		/// Gets or sets a value that indecates if the task has been
		/// flagged
		/// </summary>
		public bool Flagged { get; set; }

		/// <summary>
		/// Gets a value indicating whether a task has children tasks
		/// </summary>
		public bool HasAction { get; set; }

		/// <summary>
		/// Gets or sets whether a task is completed
		/// </summary>
		public bool IsCompleted { get; set; }

		/// <summary>
		/// Gets or sets the note on the task
		/// </summary>
		public string Note { get; set; }

		/// <summary>
		/// Gets or sets the summary for this task
		/// </summary>
		public string Summary { get; set; }

		/// <summary>
		/// Gets the description of the task that has been identified to 
		/// be completed.
		/// </summary>
		public string TaskDescription { get; private set; }

		/// <summary>
		/// Gets or sets the project that this task belongs to
		/// </summary>
		public IProject Project { get; set; }

		/// <summary>
		/// Gets the list of sub tasks for this task
		/// </summary>
		public ICollection<ITask> Tasks
		{
			get;
			private set;
		} 

		#endregion
	}
}
