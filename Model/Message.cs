
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Interfaces;
	using DonPavlik.Domain.Interfaces.Roles;

	/// <summary>
	/// Message Class definition for working with Messages
	/// </summary>
	public class Message : IMessage
	{
		/// <summary>
		/// Initializes an instance of the Message class
		/// </summary>
		public Message()
		{
			this.Body    = string.Empty;
			this.Subject = string.Empty;
			this.Tos     = new Collection<IContact>();
			this.Ccs     = new Collection<IContact>();
			this.Bccs    = new Collection<IContact>();
		}

		/// <summary>
		/// Gets or sets the message body
		/// </summary>
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the subject of the message
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// Gets or sets the sent date time of the message
		/// </summary>
		public DateTime Sent { get; set; }

		/// <summary>
		/// Gets or sets the Originator of the message. The 
		/// person who sent the message.
		/// </summary>
		public IContact From { get; set; }

		/// <summary>
		/// Gets the collection of tos for the message.
		/// </summary>
		public ICollection<IContact> Tos { get; private set; }

		/// <summary>
		/// Gets the collection of Ccs for the message.
		/// </summary>
		public ICollection<IContact> Ccs { get; private set; }

		/// <summary>
		/// Gets the collection of Bccs for the message
		/// </summary>
		public ICollection<IContact> Bccs { get; private set; }
	}
}
