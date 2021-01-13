using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyProsjekt.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        public string LearningOutcomes { get; set; }
        public string LearningMaterial { get; set; }
        public ICollection<Progress> Progress { get; set; }

        public int ModuleID { get; set; }
        public Module Module { get; set; }
    }
}
