
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class AddressTests
	{
		/// <summary>
		/// Tests that an initialized address has an empty street
		/// address.
		/// </summary>
		[TestMethod]
		public void InitializedAddressHasEmptyStreet()
		{
			Address address = new Address();

			Assert.AreEqual(string.Empty, address.Street);
		}

		/// <summary>
		/// Tests that an initialized address has an empty
		/// city
		/// </summary>
		[TestMethod]
		public void InitializedAddressHasEmptyCity()
		{
			Address address = new Address();

			Assert.AreEqual(string.Empty, address.City);
		}

		/// <summary>
		/// Tests that an initialized address has an empty state
		/// </summary>
		[TestMethod]
		public void InitializedAddressHasEmptyState()
		{
			Address address = new Address();

			Assert.AreEqual(string.Empty, address.State);
		}

		/// <summary>
		/// Tests that an initialized address has an empty zip
		/// </summary>
		[TestMethod]
		public void InitializedAddressHasEmptyZip()
		{
			Address address = new Address();

			Assert.AreEqual(string.Empty, address.Zip);
		}
	}
}
