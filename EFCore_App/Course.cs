﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_App
{
    public  class Course
    {
        
       
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        
        
    }
}
