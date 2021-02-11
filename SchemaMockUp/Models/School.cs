using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class School
    {
        [Key]
        public int ID { get; set; }
        public string SchoolName { get; set; }
        public int Courses { get; set; } //What is this??? Fråga Christer.
        public string AboutSchool { get; set; }
        public virtual List<User> Teachers { get; set; }
        public virtual List<Education> Educations { get; set; }
    }

}
