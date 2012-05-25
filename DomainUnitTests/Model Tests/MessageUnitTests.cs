
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class MessageUnitTests
	{
		/// <summary>
		/// Tests that an initialized Message has an empty body.
		/// </summary>
		[TestMethod]
		public void InitializedMessageBodyIsEmpty()
		{
			Message message = new Message();

			Assert.AreEqual(string.Empty, message.Body);
		}

		/// <summary>
		/// Tests that an initialized Message has an empty subject
		/// </summary>
		[TestMethod]
		public void InitializedMessageSubjectIsEmpty()
		{
			Message message = new Message();

			Assert.AreEqual(string.Empty, message.Subject);
		}

		/// <summary>
		/// Tests that an initialized Messages' Sent date time is
		/// the minimum date time value
		/// </summary>
		[TestMethod]
		public void InitializedMessageDateIsMinValue()
		{
			Message message = new Message();

			Assert.AreEqual(DateTime.MinValue, message.Sent);
		}
	}
}
