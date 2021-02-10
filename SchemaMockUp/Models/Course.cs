using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Course
    {
        [Key]
        public int CourseID { get; set; }
        [ForeignKey("Education")]
        public int EducationID { get; set; } //Fk
        public Education Education { get; set; }
        public string Name { get; set; } // Two names?
        public string Period { get; set; } // //Hur???? Start/End date?
        public int Points { get; set; }
        public bool IsLiaCourse { get; set; }
        public string Location { get; set; }
        public List<Class> Classes { get;  set; }

    }
}
