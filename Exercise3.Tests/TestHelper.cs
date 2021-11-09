using Exercise3.Data;
using Microsoft.EntityFrameworkCore;

namespace Exercise3.Tests
{
	public class TestHelper
	{
		public static DbContextOptions<ApplicationDbContext> GetOptionBuilder()
		{
			var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BLVKRH;Database=Db;Trusted_Connection=True;");
			//optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
			return optionsBuilder.Options;
		}
	}
}
