using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public Speciality Speciality { get; set; }

		public List<CoursePromotion> Promotions { get; set; }

		public Programme Program { get; set; }

		public School School { get; set; }
	}
}
