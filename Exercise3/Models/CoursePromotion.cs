using System;
using System.Collections.Generic;

namespace Exercise3
{
	public enum CoursePeriod
	{
		Spring = 1,
		Summer= 2,
		Autumn = 3,
		Winter = 4
	}

	public class CoursePromotion
	{
		public int Id { get; set; }
		public CoursePeriod Period { get; set; }
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
