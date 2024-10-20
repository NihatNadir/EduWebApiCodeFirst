using EduWebApiCodeFirst.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduWebApiCodeFirst.Context
{
    public class EduWebApiContext : DbContext
    {
        public EduWebApiContext(DbContextOptions<EduWebApiContext>options) : base(options)
        {
            
        }

        public DbSet<CourseEntity> Courses => Set<CourseEntity>();
        public DbSet<EnrollmentEntity> Enrollments => Set<EnrollmentEntity>();
        public DbSet<InstructorEntity> Instructors => Set<InstructorEntity>();
        public DbSet<StudentEntity> Students => Set<StudentEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CourseEntity>()
                .HasOne(c => c.Instructor) // CourseEntity instructor aldık
                .WithMany(i => i.Courses) // Bu instructor birden fazla course verebilir.
                .HasForeignKey(c => c.InstructorId); // ilişkisinin olacağı nesnenin Id'yi belirttik

            modelBuilder.Entity<EnrollmentEntity>()
                .HasOne(e => e.Student) // EnrollmentEntity Öğrencileri aldık
                .WithMany(s => s.Enrollments) // Öğrenci birden fazla kayıt yapabilir.
                .HasForeignKey(e => e.StudentId); // ilişkisinin olacağı nesnenin Id'yi belirttik

            modelBuilder.Entity<EnrollmentEntity>()
                .HasOne(e => e.Course) // EnrollmentEntity course aldık
                .WithMany(c => c.Enrollments) // bir kurs birden fazla kayıtta olabilir.
                .HasForeignKey(e => e.CourseId); // EnrollmentEntity içerisindeki nesnenin Id belirttik

            modelBuilder.Entity<CourseEntity>()
                .Property(c => c.Price)
                .HasPrecision(18, 2); // 18 adet sayı olacak ekstra ',' olacak ve ',' sağında 2 basamak yer alacak


        }


    }
}
