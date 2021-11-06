using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class ProgramPromotion
	{
		public int Id { get; set; }
		public Programme Program { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Name { get; set; }
		public List<CoursePromotion> Courses { get; set; }
		public List<StudentProgram> Students { get; set; }
	}
}
