using System;
using System.Collections.Generic;

namespace Exercise3
{
	public class Student
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }
		public DateTime FirstEnrollDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsFullTime { get; set; }
		public List<StudentProgram> Programs { get; set; }
		public List<StudentCourse> Courses { get; set; }
	}
}
