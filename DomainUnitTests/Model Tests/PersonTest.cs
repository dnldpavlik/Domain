
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

	}
}
