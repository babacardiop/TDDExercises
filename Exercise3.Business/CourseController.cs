using Exercise3.Data;
using Exercise3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Business
{
	public class CourseController
	{
		public CourseRepository repository { get; set; }
		public CourseController(ApplicationDbContext context)
		{
			repository = new CourseRepository(context);
		}
		public async Task<Course> AddCourse(Course course)
		{
			return await repository.AddCourse(course);
		}
	}
}
