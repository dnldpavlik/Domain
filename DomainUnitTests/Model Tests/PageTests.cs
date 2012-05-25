
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	/// <summary>
	/// Tests for the Page Model Class
	/// </summary>
	[TestClass]
	public class PageTests
	{
		/// <summary>
		/// Tests that when a Page is initialized that its line 
		/// collection has a length/count of 0 instead of Null
		/// </summary>
		[TestMethod]
		public void InitializedPageEmptyLines()
		{
			Page page = new Page();

			Assert.AreEqual(0, page.Lines.Count);
		}

		/// <summary>
		/// Tests that when a Page is initialized that its Metadata 
		/// collection is empty and not null;
		/// </summary>
		[TestMethod]
		public void InitializedPageEmptyMetaData()
		{
			Page page = new Page();

			Assert.AreEqual(0, page.MetaData.Count);
		}

		/// <summary>
		/// Tests that an initialized pages' name is empty.
		/// </summary>
		[TestMethod]
		public void InitializedPageEmptyName()
		{
			Page page = new Page();

			Assert.AreEqual(string.Empty, page.Name);
		}

		/// <summary>
		/// Tests that an initialized pages' file path is empty.
		/// </summary>
		[TestMethod]
		public void InitializedPageHasEmptyFilePath()
		{
			Page page = new Page();

			Assert.AreEqual(string.Empty, page.FilePath);
		}
	}
}
