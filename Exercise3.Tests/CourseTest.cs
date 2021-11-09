using Exercise3.Business;
using Exercise3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercise3.Tests
{
	public class CourseTest
	{
		DbContextOptions<ApplicationDbContext> ContextOptions { get; set; }

		public CourseTest()
		{
			ContextOptions = TestHelper.GetOptionBuilder();
		}

		[Fact]
		public async Task AddCourseTest()
		{
			using var context = new ApplicationDbContext(ContextOptions);

			var cut = new CourseController(context);
			var testCourse = new Course() { Name = "Test Course" };

			await cut.AddCourse(testCourse);

			var course = await context.Courses.SingleOrDefaultAsync(s => s.Name == "Test Course");
			Assert.NotNull(course);
		}
	}
}
