

namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class OrganizationTests
	{
		[Fact]
		public void InitializedOrgainizationDefaults()
		{
			Organization org = new Organization();

			Assert.Null(org.Address);
			Assert.Equal(string.Empty, org.Name);
			Assert.Equal(0, org.Members.Count);
		}
	}
}
