
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

		/// <summary>
		/// Tests that an initialized messages' From is null
		/// </summary>
		[TestMethod]
		public void InitializedMessageHasNullFrom()
		{
			Message message = new Message();

			Assert.IsNull(message.From);
		}

		/// <summary>
		/// Tests that an initialized messages' collection of 
		/// Tos has a length of zero
		/// </summary>
		[TestMethod]
		public void InitializedMessageHasZeroCollectionOfTos()
		{
			Message message = new Message();

			Assert.AreEqual(0, message.Tos.Count);
		}

		/// <summary>
		/// Tests that an inialized messages' collection of Ccs 
		/// has a length of zero
		/// </summary>
		[TestMethod]
		public void InitializedMessageHasZeroCollectionOfCcs()
		{
			Message message = new Message();

			Assert.AreEqual(0, message.Ccs.Count);
		}

		/// <summary>
		/// Tests that an initialized messages' collection of Bccs
		/// has a length of zero
		/// </summary>
		[TestMethod]
		public void InitializedMessageHasZeroCollectionOfBccs()
		{
			Message message = new Message();

			Assert.AreEqual(0, message.Bccs.Count);
		}
	}
}
