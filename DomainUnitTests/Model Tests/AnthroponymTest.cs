
namespace DonPavlik.Domain.DomainUnitTests
{
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
    
    /// <summary>
    ///This is a test class for AnthroponymTest and is intended
    ///to contain all AnthroponymTest Unit Tests
    ///</summary>
	[TestClass()]
	public class AnthroponymTest
	{
		/// <summary>
		/// Tests an anthroponym given name is empty
		/// </summary>
		[TestMethod]
		public void InitializedAnthroponymsGivenNameIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.AreEqual(string.Empty, anthroponym.Given);
		}

		/// <summary>
		/// Tests an anthroponym's Middle name is empty
		/// </summary>
		[TestMethod]
		public void InitializedAnthropymnsMiddleIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.AreEqual(string.Empty, anthroponym.Middle);
		}

		/// <summary>
		/// Tests an anthroponym's Surname name is empty
		/// </summary>
		[TestMethod]
		public void InitializedAnthropymnsSurnameIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.AreEqual(string.Empty, anthroponym.Surname);
		}

		/// <summary>
		/// Tests an anthroponym's Suffix name is empty
		/// </summary>
		[TestMethod]
		public void InitializedAnthropymnsSuffixIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.AreEqual(string.Empty, anthroponym.Suffix);
		}

		/// <summary>
		/// Tests an anthroponym's Prefix name is empty
		/// </summary>
		[TestMethod]
		public void InitializedAnthropymnsPrefixIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.AreEqual(string.Empty, anthroponym.Prefix);
		}

		/// <summary>
		/// Tests that when only a given name is set that full name 
		/// is the same as the given name
		/// </summary>
		[TestMethod]
		public void FullNameReturnsGiven()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Given = "John";

			Assert.AreEqual(anthroponym.Given, anthroponym.FullName);
		}

		/// <summary>
		/// Tests that when Given and Surname are set the full name
		/// is the combination of the two.
		/// </summary>
		[TestMethod]
		public void FullNameReturnGivenWithSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Given = "John";
			anthroponym.Surname = "Smith";

			Assert.AreEqual("John Smith", anthroponym.FullName);
		}

		/// <summary>
		/// Tests when a Given, Middle and Surname are set the full
		/// name is the combination of all three
		/// </summary>
		[TestMethod]
		public void FullNameReturnGivenMiddleAndSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";

			Assert.AreEqual("John Que Smith", anthroponym.FullName);
		}

		/// <summary>
		/// Test when a Prefix, Given, Middle and Surname are set
		/// the full name is combination of all four
		/// </summary>
		[TestMethod]
		public void FullNameReturnPrefixGivenMiddleSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Prefix = "Mr.";
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";

			Assert.AreEqual("Mr. John Que Smith", anthroponym.FullName);
		}

		/// <summary>
		/// Test when a Prefix, Given, Middle, Surname and Suffix
		/// are set the full name is the combination of them all
		/// </summary>
		[TestMethod]
		public void FullNamePrefixGivenMiddleSurnameSuffix()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Prefix = "Mr.";
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";
			anthroponym.Suffix = "Jr.";

			Assert.AreEqual("Mr. John Que Smith Jr.", anthroponym.FullName);
		}

		/// <summary>
		/// Test when a Middle and Surname are set, the full name 
		/// is the combination of the two
		/// </summary>
		[TestMethod]
		public void FullNameMiddleSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Prefix = "Mr.";
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";
			anthroponym.Suffix = "Jr.";

			Assert.AreEqual("Mr. John Que Smith Jr.", anthroponym.FullName);
		}
	}
}
