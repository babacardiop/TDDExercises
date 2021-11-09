using Exercise3.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Exercise3.Tests
{
	public class SchoolTest
	{
		DbContextOptions<ApplicationDbContext> ContextOptions { get; set; }

		public SchoolTest()
		{
			ContextOptions = TestHelper.GetOptionBuilder();

		}

		private void Seed()
		{
			using (var dbContext = new ApplicationDbContext(ContextOptions))
			{
				// Seed initial data, when required

			}
		}

		[Fact]
		public void AddSchool()
		{

			using var context = new ApplicationDbContext(ContextOptions);

			// Arrange
			// Assert

			// Arrange
		}

	}
}
