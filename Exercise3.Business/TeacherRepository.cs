using Exercise3.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercise3.Business
{
	public class TeacherRepository
	{
		private ApplicationDbContext _dbContext;

		public TeacherRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Teacher AddTeacher(School sc, Person person, Speciality speciality)
		{
			var teacher = new Teacher { Person = person, School = sc, Specialities = new List<Speciality> { speciality } };
			_dbContext.Teachers.Add(teacher);
			_dbContext.SaveChanges();
			return teacher;
		}

		public async Task<Teacher> GetTeacher(int id)
		{
			return await _dbContext.Teachers.AsQueryable().FirstOrDefaultAsync(t => t.Id == id);
		}
	}
}
