
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class TimeLineEntryTests
	{
		/// <summary>
		/// Tests that an initialized Time Line Entry has an
		/// empty Title
		/// </summary>
		[TestMethod]
		public void InitializedTimeLineEntryTitleIsEmpty()
		{
			TimeLineEntry timeLineEntry = new TimeLineEntry();

			Assert.AreEqual(string.Empty, timeLineEntry.Title);
		}

		/// <summary>
		/// Tests that an initialized Time Line Entry's Date Time 
		/// is the minimum date time value.
		/// </summary>
		[TestMethod]
		public void InitializedTimeLineEntryDateTimeIsMinValue()
		{
			TimeLineEntry timeLineEntry = new TimeLineEntry();

			Assert.AreEqual(DateTime.MinValue, timeLineEntry.DateTime);
		}

		/// <summary>
		/// Tests that an inialized time line entry's entry collection
		/// is zero
		/// </summary>
		[TestMethod]
		public void InitializedTimeLineEntryEntryIsZero()
		{
			TimeLineEntry timeLineEntry = new TimeLineEntry();

			Assert.AreEqual(0, timeLineEntry.Entry.Count);
		}
	}
}
