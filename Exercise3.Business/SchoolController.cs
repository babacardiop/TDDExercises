using Exercise3.Data;
using Exercise3.Repository;
using System.Threading.Tasks;

namespace Exercise3.Business
{
	public class SchoolController
	{
		public SchoolRepository Repository { get; set; }

		public SchoolController(ApplicationDbContext dbContext)
		{
			Repository = new SchoolRepository(dbContext);
		}

		public async Task<School> AddSchool(School school)
		{
			return await Repository.AddSchool(school);
		}
	}
}
