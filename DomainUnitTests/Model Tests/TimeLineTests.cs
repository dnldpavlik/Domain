
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class TimeLineTests
	{
		/// <summary>
		/// Tests an initialized Time line has its' entries collection
		/// with a count of zero
		/// </summary>
		[Fact]
		public void TestInitializedTimeLineEntriesLengthIsZero()
		{
			TimeLine timeLine = new TimeLine();

			Assert.Equal(0, timeLine.Entries.Count);
		}
	}
}
