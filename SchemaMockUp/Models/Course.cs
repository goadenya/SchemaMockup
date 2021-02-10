using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Course
    {
        [Key]
        public int CourseID { get; set; }
        public int EducationID { get; set; } //Fk
        public string Name { get; set; }
        public string Period { get; set; } //?
        public int Points { get; set; }
        public bool IsLiaCourse { get; set; }
        public string Location { get; set; }

    }
}
