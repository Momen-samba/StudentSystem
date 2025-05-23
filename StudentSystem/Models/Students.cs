using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; } 
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string Birthday { get; set; }

        public ICollection<HomeWorks> HomeWork { get; set; } = new List<HomeWorks>();
        public ICollection<StudentCourse> StudentCourse { get; set; } = new List<StudentCourse>();  
            
   }
}
