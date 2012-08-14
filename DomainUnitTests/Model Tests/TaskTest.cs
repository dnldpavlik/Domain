
namespace DonPavlik.Domain.DomainUnitTests
{
    using DonPavlik.Domain.Model;
	using System;
	using Xunit;
    
    /// <summary>
    ///This is a test class for TaskTest and is intended
    ///to contain all TaskTest Unit Tests
    ///</summary>
	public class TaskTests
	{
		/// <summary>
		/// Tests an initialized task has its flagged as false
		/// </summary>
		[Fact]
		public void InitializedTaskFlagIsFalse()
		{
			Task task = new Task();

			Assert.False(task.Flagged);
		}

		/// <summary>
		/// Tests an initialized task's Has Action is false
		/// </summary>
		[Fact]
		public void InitializedTaskHasActionIsFalse()
		{
			Task task = new Task();

			Assert.False(task.HasAction);
		}

		/// <summary>
		/// Tests an inialized task's Is Complete is False
		/// </summary>
		[Fact]
		public void IntitializedTaskIsCompleteFalse()
		{
			Task task = new Task();

			Assert.False(task.IsCompleted);
		}

		/// <summary>
		/// Tests an initialized Tasks' note is empty
		/// </summary>
		[Fact]
		public void InitializedTaskNoteIsEmpty()
		{
			Task task = new Task();

			Assert.Equal(string.Empty, task.Note);
		}

		/// <summary>
		/// Tests an initialized Tasks' summary is empty
		/// </summary>
		[Fact]
		public void InitializedTaskSummaryIsEmpty()
		{
			Task task = new Task();

			Assert.Equal(string.Empty, task.Summary);
		}

		/// <summary>
		/// Tests an initialized Tasks' description is empty
		/// </summary>
		[Fact]
		public void InitializedTaskDescriptionIsEmpty()
		{
			Task task = new Task();

			Assert.Equal(string.Empty, task.TaskDescription);
		}

		/// <summary>
		/// Tests an initialized Tasks' project is null
		/// </summary>
		[Fact]
		public void InitializedTaskProjectIsNull()
		{
			Task task = new Task();

			Assert.Null(task.Project);
		}

		/// <summary>
		/// Tests an initialized Tasks' collection of Tasks is zero
		/// </summary>
		[Fact]
		public void InitializedTaskTasksIsZero()
		{
			Task task = new Task();

			Assert.Equal(0, task.Tasks.Count);
		}

		/// <summary>
		/// Tests that a Tasks that is initialized with a task 
		/// description has the same value that was passed in.
		/// </summary>
		[Fact]
		public void InitializedTaskWithTaskDescriptionHasSameValue()
		{
			string myTask = "This is a task";
			Task task = new Task(myTask);

			Assert.Equal(myTask, task.TaskDescription);
		}
	}
}
