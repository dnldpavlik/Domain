
namespace DonPavlik.Domain.Attributes
{
	using System;
	using System.Text.RegularExpressions;
	using PostSharp.Aspects;
	using PostSharp.Aspects.Advices;
	using PostSharp.Extensibility;

	/// <summary>
	/// Regular expression attribute class definition
	/// </summary>
	[Serializable]
	public sealed class RegularExpressionAttribute : LocationInterceptionAspect
	{
		/// <summary>
		/// Initializes an instance of the Regular expression attribute
		/// class
		/// </summary>
		/// <param name="pattern">regular expression pattern</param>
		public RegularExpressionAttribute(string pattern)
		{
			this.Pattern = pattern;
		}
		
		/// <summary>
		/// Gets the pattern for this regular expression attribute
		/// </summary>
		public string Pattern { get; private set; }

		/// <summary>
		/// Method intercepting all changes on field, making sure that the
		/// setting value matches the regular expression
		/// </summary>
		/// <param name="locationInterceptionArgs">Location Interception Arguments</param>
		//[OnLocationSetValueAdvice]
		//[MulticastPointcut(Targets = MulticastTargets.Property,
		//					Attributes = MulticastAttributes.Public)]
		public override void OnSetValue(LocationInterceptionArgs locationInterceptionArgs)
		{
			bool isValid = RegEXPatterns.MatchFound(
				locationInterceptionArgs.Value.ToString(), 
				this.Pattern);

			if (isValid == false)
			{
				return;
			}

			locationInterceptionArgs.ProceedSetValue();
		}
	}
}
