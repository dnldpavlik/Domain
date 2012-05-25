

namespace DonPavlik.Domain.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

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
	}
}
