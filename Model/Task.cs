
namespace DonPavlik.Domain.Model
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Task definition for dealing with tasks
	/// </summary>
	public class Task :ITask
	{
		#region Private Fields

		private bool _flagged = false;

		private bool _hasAction = false;

		private bool _isCompleted = false;

		private string _note = string.Empty;

		private string _summary = string.Empty;

		private string _task = string.Empty; 

		#endregion

		public Task(string task)
		{
			this._task = task;
			this.Tasks = new HashSet<ITask>();
		}

		#region Public Virtual Properties

		/// <summary>
		/// Gets or sets a value that indecates if the task has been
		/// flagged
		/// </summary>
		public virtual bool Flagged
		{
			get
			{
				return this._flagged;
			}

			set
			{
				this._flagged = value;
			}
		}

		/// <summary>
		/// Gets a value indicating whether a task has children tasks
		/// </summary>
		public virtual bool HasAction
		{
			get 
			{
				return this._hasAction;
			}

			set
			{
				this._hasAction = value;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this task has a note
		/// </summary>
		public virtual bool HasNote
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(this._note))
				{
					return true;
				}

				return false;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this task has a summary
		/// </summary>
		public virtual bool HasSummary
		{
			get 
			{
				if (!string.IsNullOrWhiteSpace(this._summary))
				{
					return true;
				}

				return false;
			}
		}

		/// <summary>
		/// Gets or sets whether a task is completed
		/// </summary>
		public virtual bool IsCompleted
		{
			get
			{
				return this._isCompleted;
			}

			set
			{
				this._isCompleted = value;
			}
		}

		/// <summary>
		/// Gets or sets the note on the task
		/// </summary>
		public virtual string Note
		{
			get
			{
				return this._note;
			}

			set
			{
				this._note = value;
			}
		}

		/// <summary>
		/// Gets or sets the summary for this task
		/// </summary>
		public virtual string Summary
		{
			get
			{
				return this._summary;
			}

			set
			{
				this._summary = value;
			}
		}

		/// <summary>
		/// Gets the description of the task that has been identified to be completed.
		/// </summary>
		public virtual string TaskDescription
		{
			get
			{
				return this._task;
			}
		}

		#endregion

		#region Public Properties
		
		/// <summary>
		/// Gets a value indicating whether a task has children tasks
		/// </summary>
		public bool HasTasks
		{
			get
			{
				return this.Tasks.Count > 0;
			}
		}

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
