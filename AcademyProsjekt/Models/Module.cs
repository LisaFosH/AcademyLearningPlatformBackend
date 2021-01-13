﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyProsjekt.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection <Page> Pages { get; set; }
    }
}
