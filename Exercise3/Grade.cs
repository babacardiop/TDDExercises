using System;

namespace Exercise3
{
	public class Grade
	{
		public int Id { get; set; }
		public GradePlan GradePlan { get; set; }

		public CoursePromotion CoursePromotion { get; set; }

		public Teacher Teacher { get; set; }

		public StudentCourse StudentCourse { get; set; }

		public double Value { get; set; }

		public bool IsMissed { get; set; }

		public DateTime GradeDate { get; set; }

		public DateTime RescheduledDate { get; set; }
	}
}
