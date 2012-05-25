
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests.Roles
{
	using System;
	using DonPavlik.Domain.Interfaces;
	using DonPavlik.Domain.Model;
	using DonPavlik.Domain.Model.Roles;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class ContactTests
	{
		/// <summary>
		/// Tests that an initialized contact email is empty
		/// </summary>
		[TestMethod]
		public void InitializedContactEmailIsEmpty()
		{
			IPerson person = new Person();
			Contact contact = new Contact(person);

			Assert.AreEqual(string.Empty, contact.Email);
		}
	}
}
