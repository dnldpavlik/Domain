
namespace DonPavlik.Domain.DomainUnitTests
{
    using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
    
    /// <summary>
    ///This is a test class for TaskTest and is intended
    ///to contain all TaskTest Unit Tests
    ///</summary>
	[TestClass]
	public class TaskTests
	{
		/// <summary>
		/// Tests an initialized task has its flagged as false
		/// </summary>
		[TestMethod]
		public void InitializedTaskFlagIsFalse()
		{
			Task task = new Task();

			Assert.IsFalse(task.Flagged);
		}

		/// <summary>
		/// Tests an initialized task's Has Action is false
		/// </summary>
		[TestMethod]
		public void InitializedTaskHasActionIsFalse()
		{
			Task task = new Task();

			Assert.IsFalse(task.HasAction);
		}

		/// <summary>
		/// Tests an inialized task's Is Complete is False
		/// </summary>
		[TestMethod]
		public void IntitializedTaskIsCompleteFalse()
		{
			Task task = new Task();

			Assert.IsFalse(task.IsCompleted);
		}

		/// <summary>
		/// Tests an initialized Tasks' note is empty
		/// </summary>
		[TestMethod]
		public void InitializedTaskNoteIsEmpty()
		{
			Task task = new Task();

			Assert.AreEqual(string.Empty, task.Note);
		}

		/// <summary>
		/// Tests an initialized Tasks' summary is empty
		/// </summary>
		[TestMethod]
		public void InitializedTaskSummaryIsEmpty()
		{
			Task task = new Task();

			Assert.AreEqual(string.Empty, task.Summary);
		}

		/// <summary>
		/// Tests an initialized Tasks' description is empty
		/// </summary>
		[TestMethod]
		public void InitializedTaskDescriptionIsEmpty()
		{
			Task task = new Task();

			Assert.AreEqual(string.Empty, task.TaskDescription);
		}

		/// <summary>
		/// Tests an initialized Tasks' project is null
		/// </summary>
		[TestMethod]
		public void InitializedTaskProjectIsNull()
		{
			Task task = new Task();

			Assert.IsNull(task.Project);
		}

		/// <summary>
		/// Tests an initialized Tasks' collection of Tasks is zero
		/// </summary>
		[TestMethod]
		public void InitializedTaskTasksIsZero()
		{
			Task task = new Task();

			Assert.AreEqual(0, task.Tasks.Count);
		}

		/// <summary>
		/// Tests that a Tasks that is initialized with a task 
		/// description has the same value that was passed in.
		/// </summary>
		[TestMethod]
		public void InitializedTaskWithTaskDescriptionHasSameValue()
		{
			string myTask = "This is a task";
			Task task = new Task(myTask);

			Assert.AreEqual(myTask, task.TaskDescription);
		}
	}
}
