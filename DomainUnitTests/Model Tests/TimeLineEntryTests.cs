
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class TimeLineEntryTests
	{
		/// <summary>
		/// Tests that an initialized Time Line Entry has an
		/// empty Title
		/// </summary>
		[Fact]
		public void InitializedTimeLineEntryTitleIsEmpty()
		{
			TimeLineEntry timeLineEntry = new TimeLineEntry();

			Assert.Equal(string.Empty, timeLineEntry.Title);
		}

		/// <summary>
		/// Tests that an initialized Time Line Entry's Date Time 
		/// is the minimum date time value.
		/// </summary>
		[Fact]
		public void InitializedTimeLineEntryDateTimeIsMinValue()
		{
			TimeLineEntry timeLineEntry = new TimeLineEntry();

			Assert.Equal(DateTime.MinValue, timeLineEntry.DateTime);
		}

		/// <summary>
		/// Tests that an inialized time line entry's entry collection
		/// is zero
		/// </summary>
		[Fact]
		public void InitializedTimeLineEntryEntryIsZero()
		{
			TimeLineEntry timeLineEntry = new TimeLineEntry();

			Assert.Equal(0, timeLineEntry.Entry.Count);
		}
	}
}
