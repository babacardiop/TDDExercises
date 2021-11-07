using Microsoft.EntityFrameworkCore;
using System;

namespace Exercise3.Data
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Speciality>().HasData(
				new Speciality
				{
					Id = 1,
					Name = "Computer Sciences"
				}
			);
			modelBuilder.Entity<School>().HasData(
				new School
				{
					Id = 1,
					Name = "Coding DOJO"
				}
			);
			modelBuilder.Entity<Programme>().HasData(
				new Programme
				{
					Id = 1,
					Name = "Getting started with Web Development",
					SchoolId = 1,
					Description = "This certificate path will get you through all the basics of web development"
				}
			);
			modelBuilder.Entity<Person>().HasData(
				new Person
				{
					Id = 1,
					FirstName = "Teacher",
					LastName = "1",
					Sex = "F",
					Adress = "",
					BirthDate = DateTime.Now
				},
				new Person
				{
					Id = 2,
					FirstName = "Teacher",
					LastName = "2",
					Sex = "M",
					Adress = "",
					BirthDate = DateTime.Now
				}

			);
		}
	}
}
