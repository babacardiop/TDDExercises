// <auto-generated />
using System;
using Exercise3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exercise3.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211106215447_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exercise3.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgramId")
                        .HasColumnType("int");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Exercise3.CoursePromotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageGrade")
                        .HasColumnType("float");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int?>("ProgramPromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ProgramPromotionId");

                    b.HasIndex("TeacherId");

                    b.ToTable("CoursePromotions");
                });

            modelBuilder.Entity("Exercise3.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoursePromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GradeDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GradePlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsMissed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RescheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentCourseId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CoursePromotionId");

                    b.HasIndex("GradePlanId");

                    b.HasIndex("StudentCourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Exercise3.GradePlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attended")
                        .HasColumnType("int");

                    b.Property<int?>("CoursePromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<double>("Ponderation")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CoursePromotionId");

                    b.ToTable("GradePlans");
                });

            modelBuilder.Entity("Exercise3.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "",
                            BirthDate = new DateTime(2021, 11, 6, 17, 54, 46, 445, DateTimeKind.Local).AddTicks(2404),
                            FirstName = "Teacher",
                            LastName = "1",
                            Sex = "M"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "",
                            BirthDate = new DateTime(2021, 11, 6, 17, 54, 46, 453, DateTimeKind.Local).AddTicks(2208),
                            FirstName = "Teacher",
                            LastName = "2",
                            Sex = ""
                        });
                });

            modelBuilder.Entity("Exercise3.ProgramPromotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProgramId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("ProgramPromotions");
                });

            modelBuilder.Entity("Exercise3.Programme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Programs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This certificate path will get you through all the basics of web development",
                            Name = "Getting started with Web Development",
                            SchoolId = 1
                        });
                });

            modelBuilder.Entity("Exercise3.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coding DOJO"
                        });
                });

            modelBuilder.Entity("Exercise3.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrimarySpecialityId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrimarySpecialityId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer Sciences"
                        });
                });

            modelBuilder.Entity("Exercise3.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FirstEnrollDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFullTime")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Exercise3.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.HasIndex("StudentProgramId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("Exercise3.StudentProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CumulativeGrade")
                        .HasColumnType("float");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFullTime")
                        .HasColumnType("bit");

                    b.Property<int?>("ProgramPromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramPromotionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentPrograms");
                });

            modelBuilder.Entity("Exercise3.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.HasIndex("SchoolId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Exercise3.Course", b =>
                {
                    b.HasOne("Exercise3.Programme", "Program")
                        .WithMany("Courses")
                        .HasForeignKey("ProgramId");

                    b.HasOne("Exercise3.School", "School")
                        .WithMany("Courses")
                        .HasForeignKey("SchoolId");

                    b.HasOne("Exercise3.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId");

                    b.Navigation("Program");

                    b.Navigation("School");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("Exercise3.CoursePromotion", b =>
                {
                    b.HasOne("Exercise3.Course", "Course")
                        .WithMany("Promotions")
                        .HasForeignKey("CourseId");

                    b.HasOne("Exercise3.ProgramPromotion", "ProgramPromotion")
                        .WithMany("Courses")
                        .HasForeignKey("ProgramPromotionId");

                    b.HasOne("Exercise3.Teacher", "Teacher")
                        .WithMany("CoursePromotions")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Course");

                    b.Navigation("ProgramPromotion");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Exercise3.Grade", b =>
                {
                    b.HasOne("Exercise3.CoursePromotion", "CoursePromotion")
                        .WithMany("Grades")
                        .HasForeignKey("CoursePromotionId");

                    b.HasOne("Exercise3.GradePlan", "GradePlan")
                        .WithMany("Grades")
                        .HasForeignKey("GradePlanId");

                    b.HasOne("Exercise3.StudentCourse", "StudentCourse")
                        .WithMany("Grades")
                        .HasForeignKey("StudentCourseId");

                    b.HasOne("Exercise3.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("CoursePromotion");

                    b.Navigation("GradePlan");

                    b.Navigation("StudentCourse");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Exercise3.GradePlan", b =>
                {
                    b.HasOne("Exercise3.CoursePromotion", "CoursePromotion")
                        .WithMany("GradePlans")
                        .HasForeignKey("CoursePromotionId");

                    b.Navigation("CoursePromotion");
                });

            modelBuilder.Entity("Exercise3.ProgramPromotion", b =>
                {
                    b.HasOne("Exercise3.Programme", "Program")
                        .WithMany("Promotions")
                        .HasForeignKey("ProgramId");

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Exercise3.Programme", b =>
                {
                    b.HasOne("Exercise3.School", "School")
                        .WithMany("Programs")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("Exercise3.Speciality", b =>
                {
                    b.HasOne("Exercise3.Speciality", "PrimarySpeciality")
                        .WithMany("Related")
                        .HasForeignKey("PrimarySpecialityId");

                    b.HasOne("Exercise3.Teacher", null)
                        .WithMany("Specialities")
                        .HasForeignKey("TeacherId");

                    b.Navigation("PrimarySpeciality");
                });

            modelBuilder.Entity("Exercise3.Student", b =>
                {
                    b.HasOne("Exercise3.Person", "Person")
                        .WithOne("Student")
                        .HasForeignKey("Exercise3.Student", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exercise3.School", null)
                        .WithMany("Students")
                        .HasForeignKey("SchoolId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Exercise3.StudentCourse", b =>
                {
                    b.HasOne("Exercise3.CoursePromotion", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId");

                    b.HasOne("Exercise3.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");

                    b.HasOne("Exercise3.StudentProgram", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentProgramId");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Exercise3.StudentProgram", b =>
                {
                    b.HasOne("Exercise3.ProgramPromotion", "ProgramPromotion")
                        .WithMany("Students")
                        .HasForeignKey("ProgramPromotionId");

                    b.HasOne("Exercise3.Student", "Student")
                        .WithMany("Programs")
                        .HasForeignKey("StudentId");

                    b.Navigation("ProgramPromotion");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Exercise3.Teacher", b =>
                {
                    b.HasOne("Exercise3.Person", "Person")
                        .WithOne("Teacher")
                        .HasForeignKey("Exercise3.Teacher", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exercise3.School", null)
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Exercise3.Course", b =>
                {
                    b.Navigation("Promotions");
                });

            modelBuilder.Entity("Exercise3.CoursePromotion", b =>
                {
                    b.Navigation("GradePlans");

                    b.Navigation("Grades");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Exercise3.GradePlan", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("Exercise3.Person", b =>
                {
                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Exercise3.ProgramPromotion", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Exercise3.Programme", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Promotions");
                });

            modelBuilder.Entity("Exercise3.School", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Programs");

                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Exercise3.Speciality", b =>
                {
                    b.Navigation("Related");
                });

            modelBuilder.Entity("Exercise3.Student", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Programs");
                });

            modelBuilder.Entity("Exercise3.StudentCourse", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("Exercise3.StudentProgram", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Exercise3.Teacher", b =>
                {
                    b.Navigation("CoursePromotions");

                    b.Navigation("Specialities");
                });
#pragma warning restore 612, 618
        }
    }
}
