using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class School
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Program> Programs { get; private set; }

		public List<Course> Classes { get; set; }
		public List<Teacher> Teachers { get; set; }

		public List<Student> Student { get; set; }
	}
}
