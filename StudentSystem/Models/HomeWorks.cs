using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class HomeWorks
    {
        [Key]
        public int HomeWorkId { get; set; }
 
        public string Content { get; set; } = "c:/file.txt";

        public enum ContentType { 
          Application,
            PDF,
            ZIP
        }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Students student { get; set; }
        public Courses course { get; set; }
    }
}
