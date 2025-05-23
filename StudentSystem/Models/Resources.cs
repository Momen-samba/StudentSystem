using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Resources
    {
        [Key]
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public enum ResourceType { 
         Video,
         Presentation,
         Document,
         Other
        }
     
        public int CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
