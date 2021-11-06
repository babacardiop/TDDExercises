using System;

namespace Exercise3
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Sex { get; set; }
		public DateTime BirthDate { get; set; }
		public string Adress { get; set; }
		public Teacher Teacher { get; set; }
		public Student Student { get; set; }
	}
}
