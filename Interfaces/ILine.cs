
namespace DonPavlik.Domain.Interfaces
{
	using System;

	/// <summary>
	/// Interface definition for Line
	/// </summary>
	public interface ILine
	{
		/// <summary>
		/// Gets or sets the literal value for the line
		/// </summary>
		string LiteralValue { get; set; }

		/// <summary>
		/// Returns the string value of the Line
		/// </summary>
		/// <returns>Return Literal Value</returns>
		string ToString();
	}
}
