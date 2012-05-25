
namespace DonPavlik.Domain.Model
{
	using DonPavlik.Domain.Interfaces;

	/// <summary>
	/// Project class definition
	/// </summary>
	public class Project : IProject
	{
		/// <summary>
		/// Instanciates an instance of the Project class.
		/// </summary>
		public Project()
		{
			this.Name = string.Empty;
		}

		/// <summary>
		/// Gets and sets the name of the project
		/// </summary>
		public string Name
		{
			get;
			set;
		}
	}
}
