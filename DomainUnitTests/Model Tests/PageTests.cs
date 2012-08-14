
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using System;
	using DonPavlik.Domain.Model;
	using Xunit;

	/// <summary>
	/// Tests for the Page Model Class
	/// </summary>
	public class PageTests
	{
		/// <summary>
		/// Tests that when a Page is initialized that its line 
		/// collection has a length/count of 0 instead of Null
		/// </summary>
		[Fact]
		public void InitializedPageEmptyLines()
		{
			Page page = new Page();

			Assert.Equal(0, page.Lines.Count);
		}

		/// <summary>
		/// Tests that when a Page is initialized that its Metadata 
		/// collection is empty and not null;
		/// </summary>
		[Fact]
		public void InitializedPageEmptyMetaData()
		{
			Page page = new Page();

			Assert.Equal(0, page.MetaData.Count);
		}

		/// <summary>
		/// Tests that an initialized pages' name is empty.
		/// </summary>
		[Fact]
		public void InitializedPageEmptyName()
		{
			Page page = new Page();

			Assert.Equal(string.Empty, page.Name);
		}

		/// <summary>
		/// Tests that an initialized pages' file path is empty.
		/// </summary>
		[Fact]
		public void InitializedPageHasEmptyFilePath()
		{
			Page page = new Page();

			Assert.Equal(string.Empty, page.FilePath);
		}
	}
}
