using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
	public class StudentCourse
	{
		public int Id { get; set; }
		public Student Student { get; set; }
		public CoursePromotion Course { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public List<Grade> Grades { get; set; }
	}
}
