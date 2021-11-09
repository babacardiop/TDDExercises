using Exercise3.Data;
using Exercise3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Business
{
	public class SchoolController
	{
		public TeacherRepository Repository { get; set; }

		public SchoolController(ApplicationDbContext dbContext)
		{
			Repository = new TeacherRepository(dbContext);
		}
	}
}
