
namespace DonPavlik.Domain.DomainUnitTests
{
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using DonPavlik.Domain.Interfaces;
	using System.Collections.Generic;    
    
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
	[TestClass()]
	public class PersonTest
	{
		/// <summary>
		///A test for Person Constructor
		///</summary>
		[TestMethod()]
		public void PersonConstructorTest()
		{
			Person target = new Person();
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for DateOfBirth
		///</summary>
		[TestMethod()]
		public void DateOfBirthTest()
		{
			Person target = new Person(); // TODO: Initialize to an appropriate value
			DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
			DateTime actual;
			target.DateOfBirth = expected;
			actual = target.DateOfBirth;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for DateOfDeath
		///</summary>
		[TestMethod()]
		public void DateOfDeathTest()
		{
			Person target = new Person(); // TODO: Initialize to an appropriate value
			Nullable<DateTime> expected = new Nullable<DateTime>(); // TODO: Initialize to an appropriate value
			Nullable<DateTime> actual;
			target.DateOfDeath = expected;
			actual = target.DateOfDeath;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Gender
		///</summary>
		[TestMethod()]
		public void GenderTest()
		{
			Person target = new Person(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Gender = expected;
			actual = target.Gender;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
