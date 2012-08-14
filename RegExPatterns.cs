using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DonPavlik.Domain
{
	/// <summary>
	/// Regular expression patterns class definition
	/// </summary>
	public static class RegEXPatterns
	{
		public const string ZIP_CODE = @"^(\d{5}-\d{4}|\d{5}|\d{9})$";

		/// <summary>
		/// Matches the found.
		/// </summary>
		/// <param name="searchString">The search string.</param>
		/// <param name="regExPattern">The reg ex pattern.</param>
		/// <returns></returns>
		public static bool MatchFound(string searchString, string regExPattern)
		{
			Regex re = new Regex(regExPattern);
			bool isValid = re.IsMatch(searchString);

			return isValid;
		}
	}
}
