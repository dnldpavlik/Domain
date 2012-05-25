
namespace DonPavlik.Domain.Model
{
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Class definition for Line
	/// </summary>
	public class Line : ILine
	{
		/// <summary>
		/// Initializes an instance of Line
		/// </summary>
		public Line()
		{
			this.LiteralValue = string.Empty;
		}

		/// <summary>
		/// Gets or sets the literal value for the line
		/// </summary>
		public string LiteralValue { get; set; }

		/// <summary>
		/// Returns the string value of the Line
		/// </summary>
		/// <returns>Return Literal Value</returns>
		public override string ToString()
		{
			return this.LiteralValue;
		}
	}
}
