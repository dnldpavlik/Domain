
namespace DonPavlik.Domain.DomainUnitTests
{
	using DonPavlik.Domain.Model;
	using System;
	using Xunit;
    
    /// <summary>
    ///This is a test class for AnthroponymTest and is intended
    ///to contain all AnthroponymTest Unit Tests
    ///</summary>
	public class AnthroponymTest
	{
		/// <summary>
		/// Tests an anthroponym given name is empty
		/// </summary>
		[Fact]
		public void InitializedAnthroponymsGivenNameIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.Equal(string.Empty, anthroponym.Given);
		}

		/// <summary>
		/// Tests an anthroponym's Middle name is empty
		/// </summary>
		[Fact]
		public void InitializedAnthropymnsMiddleIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.Equal(string.Empty, anthroponym.Middle);
		}

		/// <summary>
		/// Tests an anthroponym's Surname name is empty
		/// </summary>
		[Fact]
		public void InitializedAnthropymnsSurnameIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.Equal(string.Empty, anthroponym.Surname);
		}

		/// <summary>
		/// Tests an anthroponym's Suffix name is empty
		/// </summary>
		[Fact]
		public void InitializedAnthropymnsSuffixIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.Equal(string.Empty, anthroponym.Suffix);
		}

		/// <summary>
		/// Tests an anthroponym's Prefix name is empty
		/// </summary>
		[Fact]
		public void InitializedAnthropymnsPrefixIsEmpty()
		{
			Anthroponym anthroponym = new Anthroponym();

			Assert.Equal(string.Empty, anthroponym.Prefix);
		}

		/// <summary>
		/// Tests that when only a given name is set that full name 
		/// is the same as the given name
		/// </summary>
		[Fact]
		public void FullNameReturnsGiven()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Given = "John";

			Assert.Equal(anthroponym.Given, anthroponym.FullName);
		}

		/// <summary>
		/// Tests that when Given and Surname are set the full name
		/// is the combination of the two.
		/// </summary>
		[Fact]
		public void FullNameReturnGivenWithSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Given = "John";
			anthroponym.Surname = "Smith";

			Assert.Equal("John Smith", anthroponym.FullName);
		}

		/// <summary>
		/// Tests when a Given, Middle and Surname are set the full
		/// name is the combination of all three
		/// </summary>
		[Fact]
		public void FullNameReturnGivenMiddleAndSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";

			Assert.Equal("John Que Smith", anthroponym.FullName);
		}

		/// <summary>
		/// Test when a Prefix, Given, Middle and Surname are set
		/// the full name is combination of all four
		/// </summary>
		[Fact]
		public void FullNameReturnPrefixGivenMiddleSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Prefix = "Mr.";
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";

			Assert.Equal("Mr. John Que Smith", anthroponym.FullName);
		}

		/// <summary>
		/// Test when a Prefix, Given, Middle, Surname and Suffix
		/// are set the full name is the combination of them all
		/// </summary>
		[Fact]
		public void FullNamePrefixGivenMiddleSurnameSuffix()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Prefix = "Mr.";
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";
			anthroponym.Suffix = "Jr.";

			Assert.Equal("Mr. John Que Smith Jr.", anthroponym.FullName);
		}

		/// <summary>
		/// Test when a Middle and Surname are set, the full name 
		/// is the combination of the two
		/// </summary>
		[Fact]
		public void FullNameMiddleSurname()
		{
			Anthroponym anthroponym = new Anthroponym();
			anthroponym.Prefix = "Mr.";
			anthroponym.Given = "John";
			anthroponym.Middle = "Que";
			anthroponym.Surname = "Smith";
			anthroponym.Suffix = "Jr.";

			Assert.Equal("Mr. John Que Smith Jr.", anthroponym.FullName);
		}

		[Fact]
		public void SetFullName()
		{
			string firstName = "John";
			string lastName = "Smith";

			Anthroponym anthroponym = new Anthroponym();
			anthroponym.FullName = firstName + " " + lastName;

			Assert.Equal(firstName, anthroponym.Given);
			Assert.Equal(lastName, anthroponym.Surname);
		}

		[Fact]
		public void SetFullNameWithJustFirstName()
		{
			string firstName = "John";

			Anthroponym anthroponym = new Anthroponym();
			anthroponym.FullName = firstName;

			Assert.Equal(firstName, anthroponym.Given);
			Assert.Equal(string.Empty, anthroponym.Surname);
		}
	}
}
