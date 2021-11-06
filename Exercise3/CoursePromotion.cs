using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
	public class CoursePromotion
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public Course Course { get; set; }

		public ProgramPromotion ProgramPromotion { get; set; }

		public Teacher Teacher { get; set; }

		public List<StudentCourse> Students { get; set; }

		public List<GradePlan> GradePlans { get; set; }

		public List<Grade> Grades { get; set; }

		public double AverageGrade { get; set; }
	}
}
