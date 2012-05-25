
namespace DonPavlik.Domain.Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Interfaces;

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
			this.Body = string.Empty;
			this.Subject = string.Empty;
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

		
	}
}
