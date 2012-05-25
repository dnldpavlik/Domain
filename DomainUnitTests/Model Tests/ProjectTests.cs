
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using DonPavlik.Domain.Model;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class ProjectTests
	{
		/// <summary>
		/// Tests to verify that when a project is instanciated
		/// that its name is empty.
		/// </summary>
		[TestMethod]
		public void InitializedWithNameEmpty()
		{
			Project project = new Project();

			Assert.AreEqual(string.Empty, project.Name);
		}
	}
}
