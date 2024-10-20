using System.ComponentModel.DataAnnotations;

namespace EduWebApiCodeFirst.Data.Entities
{
    public class InstructorEntity : BaseEntity<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

        // Relational Property
        public List<CourseEntity> Courses { get; set; }
    }
}
