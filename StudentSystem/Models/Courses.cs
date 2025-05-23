using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<Resources> resources { get; set; } = new List<Resources>();
        public ICollection<HomeWorks> homeWorks { get; set; } = new List<HomeWorks>();
        public ICollection<StudentCourse> StudentCourse { get; set; } = new List<StudentCourse>();
    }
}
