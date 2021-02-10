using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class School
    {
        [Key]
        public int SchoolID { get; set; }
        public string SchoolName { get; set; }
        public int Courses { get; set; } //???
        public string AboutSchool { get; set; }
        public string Teachers { get; set; } //?
    }
}
