using System.ComponentModel.DataAnnotations;

namespace EduWebApiCodeFirst.Data.Entities
{
    public class StudentEntity : BaseEntity<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime DateofBirth { get; set; }

        public List<EnrollmentEntity> Enrollments { get; set; }
       


    }
}
