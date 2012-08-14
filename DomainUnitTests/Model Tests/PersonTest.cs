
namespace DonPavlik.Domain.DomainUnitTests
{
	using DonPavlik.Domain.Model;
	using System;
	using DonPavlik.Domain.Interfaces;
	using System.Collections.Generic;
	using Xunit;    
    
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
	public class PersonTest
	{
		/// <summary>
		/// Tests that an initialized person doesn't have a time line
		/// set
		/// </summary>
		[Fact]
		public void InitializedPersonHasNullTimeLine()
		{
			Person person = new Person();

			Assert.Null(person.TimeLine);
		}

		/// <summary>
		/// Tests an initialized Person has an null address
		/// </summary>
		[Fact]
		public void InitializedPersonHasNullAddress()
		{
			Person person = new Person();

			Assert.Null(person.Address);
		}

		/// <summary>
		/// Tests an initialized Person has an empty collection for
		/// aliases
		/// </summary>
		[Fact]
		public void InitializedPersonHasAnEmptyAliasesCollection()
		{
			Person person = new Person();

			Assert.Equal(0, person.Aliases.Count);
		}

		/// <summary>
		/// Tests an initialized Person has a null Primary name
		/// </summary>
		[Fact]
		public void InitializedPersonHasNullPrimaryName()
		{
			Person person = new Person();

			Assert.NotNull(person.PrimaryName);
		}

		/// <summary>
		/// Tests an initialized Person has an empty Gender
		/// </summary>
		[Fact]
		public void InitializedPersonHasEmptyGender()
		{
			Person person = new Person();

			Assert.Equal(string.Empty, person.Gender);
		}

		/// <summary>
		/// Tests an initialized Person has a null date of death
		/// </summary>
		[Fact]
		public void InitialiedPersonHasNullDateOfDate()
		{
			Person person = new Person();

			Assert.Null(person.DateOfDeath);
		}

		/// <summary>
		/// Test an initialized Person has a null date of birth
		/// </summary>
		[Fact]
		public void InitializedPersonHasNullDateOfBirth()
		{
			Person person = new Person();

			Assert.Null(person.DateOfBirth);
		}
	}
}
