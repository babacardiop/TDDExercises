using Microsoft.EntityFrameworkCore;

namespace Exercise3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Programme> Programs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ProgramPromotion> ProgramPromotions { get; set; }
        public DbSet<CoursePromotion> CoursePromotions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentProgram> StudentPrograms { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<GradePlan> GradePlans { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BLVKRH;Database=Db;Trusted_Connection=True;");
            //optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
