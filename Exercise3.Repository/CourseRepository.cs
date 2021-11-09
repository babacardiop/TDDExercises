using Exercise3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Repository
{
	public class CourseRepository
	{
		private ApplicationDbContext _dbContext;

		public CourseRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Course> AddCourse(Course course)
		{
			_dbContext.Courses.Add(course);
			await _dbContext.SaveChangesAsync();
			return course;
		}
	}
}
