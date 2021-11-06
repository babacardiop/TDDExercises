using System.Collections.Generic;

namespace Exercise3
{
	public class Speciality
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public Speciality PrimarySpeciality { get; set; }
		public List<Speciality> Related { get; set; }
	}
}
