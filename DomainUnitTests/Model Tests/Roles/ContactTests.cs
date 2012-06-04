
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

		/// <summary>
		/// Tests that a contacts has the same address as a person
		/// </summary>
		[TestMethod]
		public void ContactsAddressSameAsPerson()
		{
			IPerson person = new Person();
			person.Address = new Address();
			person.Address.City = "Somewhere";
			Contact contact = new Contact(person);

			Assert.AreEqual(person.Address.City, contact.Address.City);
		}
	}
}
