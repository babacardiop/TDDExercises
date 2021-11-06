using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
	public enum ProgramType
	{
		Certificate=1,
		Bachelor = 2,
		M1=3,
		Master=4,
		PhD=5
	}
	public class Program
	{
		public int Id { get; set; }
		public string Name { get; set; }
		
		public string Description { get; set; }

		public List<Course> Courses { get; set; }

		public List<ProgramPromotion> Promotions { get; set; }
	}
}
