using DonPavlik.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DonPavlik.Domain.DomainUnitTests
{
    
    
    /// <summary>
    ///This is a test class for AnthroponymTest and is intended
    ///to contain all AnthroponymTest Unit Tests
    ///</summary>
	[TestClass()]
	public class AnthroponymTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Anthroponym Constructor
		///</summary>
		[TestMethod()]
		public void AnthroponymConstructorTest()
		{
			Anthroponym target = new Anthroponym();
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for FullName
		///</summary>
		[TestMethod()]
		public void FullNameTest()
		{
			Anthroponym target = new Anthroponym(); // TODO: Initialize to an appropriate value
			string actual;
			actual = target.FullName;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Given
		///</summary>
		[TestMethod()]
		public void GivenTest()
		{
			Anthroponym target = new Anthroponym(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Given = expected;
			actual = target.Given;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Middle
		///</summary>
		[TestMethod()]
		public void MiddleTest()
		{
			Anthroponym target = new Anthroponym(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Middle = expected;
			actual = target.Middle;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Prefix
		///</summary>
		[TestMethod()]
		public void PrefixTest()
		{
			Anthroponym target = new Anthroponym(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Prefix = expected;
			actual = target.Prefix;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Suffix
		///</summary>
		[TestMethod()]
		public void SuffixTest()
		{
			Anthroponym target = new Anthroponym(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Suffix = expected;
			actual = target.Suffix;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Surname
		///</summary>
		[TestMethod()]
		public void SurnameTest()
		{
			Anthroponym target = new Anthroponym(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Surname = expected;
			actual = target.Surname;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
