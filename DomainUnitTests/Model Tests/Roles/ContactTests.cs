
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests.Roles
{
	using System;
	using DonPavlik.Domain.Interfaces;
	using DonPavlik.Domain.Model;
	using DonPavlik.Domain.Model.Roles;
	using Xunit;

	public class ContactTests
	{
		/// <summary>
		/// Tests that an initialized contact email is empty
		/// </summary>
		[Fact]
		public void InitializedContactEmailIsEmpty()
		{
			IPerson person = new Person();
			Contact contact = new Contact(person);

			Assert.Equal(string.Empty, contact.Email);
		}

		/// <summary>
		/// Tests that a contacts has the same address as a person
		/// </summary>
		[Fact]
		public void ContactsAddressSameAsPerson()
		{
			string street = "132 Street";
			string image = "test.jpg";
			IPerson person = new Person();
			person.Address = new Address();
			person.Address.City = "Somewhere";
			Contact contact = new Contact(person);

			Assert.Equal(person.Address.City, contact.Address.City);
			Assert.Equal(person.DateOfBirth, contact.DateOfBirth);
			Assert.Equal(person.Aliases, contact.Aliases);
			Assert.Equal(person.DateOfDeath, contact.DateOfDeath);
			Assert.Equal(person.Gender, contact.Gender);
			Assert.Equal(person.PrimaryName, contact.PrimaryName);
			Assert.Equal(person.TimeLine, contact.TimeLine);
			Assert.Null(contact.Image);

			contact.Address = new Address(street);
			contact.DateOfBirth = new DateTime(2012, 6, 25);
			contact.DateOfDeath = new DateTime(2012, 6, 30);
			contact.Gender = "Male";
			contact.Image = image;

			Assert.Equal(person.DateOfDeath, contact.DateOfDeath);
			Assert.Equal(person.Gender, contact.Gender);
			Assert.Equal(person.Address.Street, contact.Address.Street);
			Assert.Equal(person.DateOfBirth, contact.DateOfBirth);
			Assert.Equal(image, contact.Image);
		}
	}
}
