using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyProsjekt.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Progress> Progress { get; set; }

    }
}
