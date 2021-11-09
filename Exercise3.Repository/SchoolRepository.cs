using Exercise3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Repository
{
	public class SchoolRepository
	{
		private ApplicationDbContext _dbContext;

		public SchoolRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<School> AddSchool(School school)
		{
			_dbContext.Schools.Add(school);
			await _dbContext.SaveChangesAsync();
			return school;
		}
	}
}
