using Exercise3.Data;
using Microsoft.EntityFrameworkCore;

namespace Exercise3.Tests
{
	public class TestHelper
	{
		public static DbContextOptions<ApplicationDbContext> GetOptionBuilder()
		{
			var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
			optionsBuilder.UseSqlServer(@"Server=Data Source=SQL5063.site4now.net;Initial Catalog=db_a5a844_tdd;User Id=db_a5a844_tdd_admin;Password=Test1234;");
			return optionsBuilder.Options;
		}
	}
}
