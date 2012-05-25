
namespace DonPavlik.Domain.DomainUnitTests
{
    using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
    
    /// <summary>
    ///This is a test class for TaskTest and is intended
    ///to contain all TaskTest Unit Tests
    ///</summary>
	[TestClass()]
	public class TaskTest
	{
		/// <summary>
		///A test for Task Constructor
		///</summary>
		[TestMethod()]
		public void TaskConstructorTest()
		{	
			string exampleTask = "Test this task class";
			Task target = new Task(exampleTask);

			Assert.Inconclusive("TODO: Implement code to verify target");
		}
	}
}
