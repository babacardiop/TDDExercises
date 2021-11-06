using System.Collections.Generic;

namespace Exercise3
{
	public class Teacher
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }
		public List<CoursePromotion> CoursePromotions { get; set; }
		public List<Speciality> Specialities { get; set; }
	}
}
