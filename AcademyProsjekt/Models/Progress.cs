using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyProsjekt.Models
{
    public class Progress
    {
        [Key]
        public int Id { get; set; }
        public double Progression { get; set; }
        public int PageId { get; set; }

        public Page Page { get; set; }
        public int StudentId { get; set; }

        public Student Student { get; set; }


    }
}
