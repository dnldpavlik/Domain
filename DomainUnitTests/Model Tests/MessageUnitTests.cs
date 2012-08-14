
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	public class MessageUnitTests
	{
		/// <summary>
		/// Tests that an initialized Message has an empty body.
		/// </summary>
		[Fact]
		public void InitializedMessageBodyIsEmpty()
		{
			Message message = new Message();

			Assert.Equal(string.Empty, message.Body);
		}

		/// <summary>
		/// Tests that an initialized Message has an empty subject
		/// </summary>
		[Fact]
		public void InitializedMessageSubjectIsEmpty()
		{
			Message message = new Message();

			Assert.Equal(string.Empty, message.Subject);
		}

		/// <summary>
		/// Tests that an initialized Messages' Sent date time is
		/// the minimum date time value
		/// </summary>
		[Fact]
		public void InitializedMessageDateIsMinValue()
		{
			Message message = new Message();

			Assert.Equal(DateTime.MinValue, message.Sent);
		}

		/// <summary>
		/// Tests that an initialized messages' From is null
		/// </summary>
		[Fact]
		public void InitializedMessageHasNullFrom()
		{
			Message message = new Message();

			Assert.Null(message.From);
		}

		/// <summary>
		/// Tests that an initialized messages' collection of 
		/// Tos has a length of zero
		/// </summary>
		[Fact]
		public void InitializedMessageHasZeroCollectionOfTos()
		{
			Message message = new Message();

			Assert.Equal(0, message.Tos.Count);
		}

		/// <summary>
		/// Tests that an inialized messages' collection of Ccs 
		/// has a length of zero
		/// </summary>
		[Fact]
		public void InitializedMessageHasZeroCollectionOfCcs()
		{
			Message message = new Message();

			Assert.Equal(0, message.Ccs.Count);
		}

		/// <summary>
		/// Tests that an initialized messages' collection of Bccs
		/// has a length of zero
		/// </summary>
		[Fact]
		public void InitializedMessageHasZeroCollectionOfBccs()
		{
			Message message = new Message();

			Assert.Equal(0, message.Bccs.Count);
		}
	}
}
