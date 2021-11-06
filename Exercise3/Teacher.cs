using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
	public class Teacher
	{
		public int Id { get; set; }

		public Person Person { get; set; }

		public List<CoursePromotion> CoursePromotions { get; set; }

		public List<Speciality> Specialities { get; set; }
	}
}
