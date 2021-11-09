using Exercise3.Business;
using Exercise3.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
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
		public async Task AddSchool()
		{
			// Arrange
			using var context = new ApplicationDbContext(ContextOptions);

			var cut = new SchoolController(context);
			
			var testSchool = new School() { Name = "Test School" };

			// Act
			await cut.AddSchool(testSchool);

			// Assert
			var school = await context.Schools.SingleOrDefaultAsync(s => s.Name == "Test School");
			Assert.NotNull(school);
		}

	}
}
