
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class TimeLineTests
	{
		/// <summary>
		/// Tests an initialized Time line has its' entries collection
		/// with a count of zero
		/// </summary>
		[TestMethod]
		public void TestInitializedTimeLineEntriesLengthIsZero()
		{
			TimeLine timeLine = new TimeLine();

			Assert.AreEqual(0, timeLine.Entries.Count);
		}
	}
}
