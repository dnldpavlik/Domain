

namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DonPavlik.Domain.Interfaces.Roles;

	public interface IMessage
	{
		/// <summary>
		/// Gets or sets the message body
		/// </summary>
		string Body { get; set; }

		/// <summary>
		/// Gets or sets the subject of the message
		/// </summary>
		string Subject { get; set; }

		/// <summary>
		/// Gets or sets the sent date time of the message
		/// </summary>
		DateTime Sent { get; set; }

		/// <summary>
		/// Gets or sets the Originator of the message. The 
		/// person who sent the message.
		/// </summary>
		IContact From { get; set; }

		/// <summary>
		/// Gets the collection of tos for the message.
		/// </summary>
		ICollection<IContact> Tos { get; }

		/// <summary>
		/// Gets the collection of Ccs for the message.
		/// </summary>
		ICollection<IContact> Ccs { get; }

		/// <summary>
		/// Gets the collection of Bccs for the message
		/// </summary>
		ICollection<IContact> Bccs { get; }
	}
}
