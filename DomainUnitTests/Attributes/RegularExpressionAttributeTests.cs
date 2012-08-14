
namespace DonPavlik.Domain.DomainUnitTests.Attributes
{
	using System;
	using DonPavlik.Domain.Attributes;
	using Xunit;

	public class RegularExpressionAttributeTests
	{
		[Fact]
		public void PatternSet()
		{
			string zipExpression = @"^(\d{5}-\d{4}|\d{5}|\d{9})$";
			RegularExpressionAttribute attribute =
				new RegularExpressionAttribute(zipExpression);

			Assert.Equal(zipExpression, attribute.Pattern);
		}
	}
}
