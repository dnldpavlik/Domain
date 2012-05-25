
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class LineTests
	{
		/// <summary>
		/// Tests that the initialized lines' literal value is empty
		/// </summary>
		[TestMethod]
		public void InitalizedLineLiteralValueIsEmpty()
		{
			Line line = new Line();

			Assert.AreEqual(string.Empty, line.LiteralValue);
		}

		/// <summary>
		/// Tests that a Lines to string returns the same value as
		/// Literal Value.
		/// </summary>
		[TestMethod]
		public void LinesToStringEqualsLiteralValue()
		{
			string testLine = "Test Value";
			Line line = new Line();
			line.LiteralValue = testLine;

			Assert.AreEqual(testLine, line.ToString());
		}

		/// <summary>
		/// Test that a Lines' Literal Value getter returns
		/// the same value that is set.
		/// </summary>
		[TestMethod]
		public void LinesLiteralValueIsTheSameThatItWasSetTo()
		{
			string testLine = "Test Value";
			Line line = new Line();
			line.LiteralValue = testLine;

			Assert.AreEqual(testLine, line.LiteralValue);
		}
	}
}
