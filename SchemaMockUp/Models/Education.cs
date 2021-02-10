using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Education
    {
        [Key]
        public int EducationID { get; set; }
        public School School { get; set; } //FK
        public string Name { get; set; }
        public string Period { get; set; } //Hur????
        public int Points { get; set; }
        public bool IsLiaCourses { get; set; }
        public string City { get; set; }

    }
}
