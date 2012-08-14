
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class LineTests
	{
		/// <summary>
		/// Tests that the initialized lines' literal value is empty
		/// </summary>
		[Fact]
		public void InitalizedLineLiteralValueIsEmpty()
		{
			Line line = new Line();

			Assert.Equal(string.Empty, line.LiteralValue);
		}

		/// <summary>
		/// Tests that a Lines to string returns the same value as
		/// Literal Value.
		/// </summary>
		[Fact]
		public void LinesToStringEqualsLiteralValue()
		{
			string testLine = "Test Value";
			Line line = new Line();
			line.LiteralValue = testLine;

			Assert.Equal(testLine, line.ToString());
		}

		/// <summary>
		/// Test that a Lines' Literal Value getter returns
		/// the same value that is set.
		/// </summary>
		[Fact]
		public void LinesLiteralValueIsTheSameThatItWasSetTo()
		{
			string testLine = "Test Value";
			Line line = new Line();
			line.LiteralValue = testLine;

			Assert.Equal(testLine, line.LiteralValue);
		}
	}
}
