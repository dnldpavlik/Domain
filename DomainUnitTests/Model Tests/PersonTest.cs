
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
		/// Tests that an initialized person doesn't have a time line
		/// set
		/// </summary>
		[TestMethod]
		public void InitializedPersonHasNullTimeLine()
		{
			Person person = new Person();

			Assert.IsNull(person.TimeLine);
		}

		/// <summary>
		/// Tests an initialized Person has an null address
		/// </summary>
		[TestMethod]
		public void InitializedPersonHasNullAddress()
		{
			Person person = new Person();

			Assert.IsNull(person.Address);
		}

		/// <summary>
		/// Tests an initialized Person has an empty collection for
		/// aliases
		/// </summary>
		[TestMethod]
		public void InitializedPersonHasAnEmptyAliasesCollection()
		{
			Person person = new Person();

			Assert.AreEqual(0, person.Aliases.Count);
		}

		/// <summary>
		/// Tests an initialized Person has a null Primary name
		/// </summary>
		[TestMethod]
		public void InitializedPersonHasNullPrimaryName()
		{
			Person person = new Person();

			Assert.IsNull(person.PrimaryName);
		}

		/// <summary>
		/// Tests an initialized Person has an empty Gender
		/// </summary>
		[TestMethod]
		public void InitializedPersonHasEmptyGender()
		{
			Person person = new Person();

			Assert.AreEqual(string.Empty, person.Gender);
		}

		/// <summary>
		/// Tests an initialized Person has a null date of death
		/// </summary>
		[TestMethod]
		public void InitialiedPersonHasNullDateOfDate()
		{
			Person person = new Person();

			Assert.IsNull(person.DateOfDeath);
		}

		/// <summary>
		/// Test an initialized Person has a null date of birth
		/// </summary>
		[TestMethod]
		public void InitializedPersonHasNullDateOfBirth()
		{
			Person person = new Person();

			Assert.IsNull(person.DateOfBirth);
		}
	}
}
