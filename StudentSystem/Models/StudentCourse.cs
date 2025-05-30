﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{

    [PrimaryKey(nameof(StudentId),nameof(CourseId))]
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Students Student { get; set; }
        public Courses Course { get; set; }
    }
}
