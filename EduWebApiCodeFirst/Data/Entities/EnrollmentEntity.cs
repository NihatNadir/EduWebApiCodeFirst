using System.ComponentModel.DataAnnotations.Schema;

namespace EduWebApiCodeFirst.Data.Entities
{
    public class EnrollmentEntity : BaseEntity<int>
    {

        public int StudentId { get; set; }

        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Relational Property
        [ForeignKey(nameof(StudentId))]
        public StudentEntity Student { get; set; }

        [ForeignKey(nameof(CourseId))]
        public CourseEntity Course { get; set; }

    }
}
