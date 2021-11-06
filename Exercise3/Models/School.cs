using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class School
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Programme> Programs { get; private set; }

		public List<Course> Courses { get; set; }
		public List<Teacher> Teachers { get; set; }

		public List<Student> Students { get; set; }
	}
}
