using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_App
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }

        [ForeignKey("CourseEnrolled")]
        public int  CourseEnrolled { get; set; }
    }
}
