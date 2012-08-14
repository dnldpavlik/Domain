
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class AddressTests
	{
		/// <summary>
		/// Tests that an initialized address has an empty street
		/// address.
		/// </summary>
		[Fact]
		public void InitializedAddressHasEmptyStreet()
		{
			Address address = new Address();

			Assert.Equal(string.Empty, address.Street);
		}

		/// <summary>
		/// Tests that an initialized address has an empty
		/// city
		/// </summary>
		[Fact]
		public void InitializedAddressHasEmptyCity()
		{
			Address address = new Address();

			Assert.Equal(string.Empty, address.City);
		}

		/// <summary>
		/// Tests that an initialized address has an empty state
		/// </summary>
		[Fact]
		public void InitializedAddressHasEmptyState()
		{
			Address address = new Address();

			Assert.Equal(string.Empty, address.State);
		}

		/// <summary>
		/// Tests that an initialized address has an empty zip
		/// </summary>
		[Fact]
		public void InitializedAddressHasEmptyZip()
		{
			Address address = new Address();

			Assert.Null(address.Zip);
		}

		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void InitializedAddresZipOnlyAceptsValidValues()
		{
			string badZip = "asdfg";
			string goodZip = "44331";

			Address address = new Address();

			address.Zip = badZip;
			Assert.Null(address.Zip);

			address.Zip = goodZip;
			Assert.Equal(goodZip, address.Zip);
		}

		[Fact]
		public void InitializedAddressWithJustStreetAddress()
		{
			string streetAddress = "123 Anywhere St";
			Address address = new Address(streetAddress);

			Assert.Equal(streetAddress, address.Street);
		}

		[Fact]
		public void InitializedAddressWithStreetAndCity()
		{
			string street = "123 Anywhere St";
			string city = "Somewhere";

			string streetAndCityAddress = street + ", " + city;
			Address address = new Address(streetAndCityAddress);

			Assert.Equal(street, address.Street);
			Assert.Equal(city, address.City);
		}

		[Fact]
		public void InitializedAddressWithStreetCityAndState()
		{
			string street = "123 Anywhere St";
			string city = "Somewhere";
			string state = "AZ";

			string streetCityState = street + ", " + city + ", " + state;
			Address address = new Address(streetCityState);

			Assert.Equal(street, address.Street);
			Assert.Equal(city, address.City);
			Assert.Equal(state, address.State);
		}

		[Fact]
		public void InitializedAddressWithStreetCityStateZip()
		{
			string street = "123 Anywhere St";
			string city = "Somewhere";
			string state = "AZ";
			string zip = "98765";

			string streetCityState = street + ", " + city + ", " + state + " " + zip;
			Address address = new Address(streetCityState);

			Assert.Equal(street, address.Street);
			Assert.Equal(city, address.City);
			Assert.Equal(state, address.State);
			Assert.Equal(zip, address.Zip);
		}
	}
}
