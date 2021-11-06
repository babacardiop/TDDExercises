using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class StudentProgram
	{
		public int Id { get; set; }
		public Student Student { get; set; }
		public ProgramPromotion ProgramPromotion { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public bool IsActive { get; set; }

		public bool IsFullTime { get; set; }

		public double CumulativeGrade { get; set; }

		public List<StudentCourse> Courses { get; set; }
	}
}
