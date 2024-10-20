using System.ComponentModel.DataAnnotations;

namespace EduWebApiCodeFirst.Data.Entities
{
    public class CourseEntity : BaseEntity<int>
    {

        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int InstructorId { get; set; }
        public List<EnrollmentEntity> Enrollments { get; set; }

        // Relational Property
        public InstructorEntity Instructor { get; set; }
        



    }
}
