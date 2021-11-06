using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class GradePlan
	{
		public int Id { get; set; }
		public CoursePromotion CoursePromotion { get; set; }

		public int Order { get; set; }

		public double Ponderation { get; set; }

		public string Name { get; set; }

		public DateTime Date { get; set; }

		public int Attended { get; set; }

		public List<Grade> Grades { get; set; }
	}
}
