
namespace DonPavlik.Domain.DomainUnitTests.Model_Tests
{
	using DonPavlik.Domain.Model;
	using Xunit;

	public class ProjectTests
	{
		/// <summary>
		/// Tests to verify that when a project is instanciated
		/// that its name is empty.
		/// </summary>
		[Fact]
		public void InitializedWithNameEmpty()
		{
			Project project = new Project();

			Assert.Equal(string.Empty, project.Name);
		}
	}
}
