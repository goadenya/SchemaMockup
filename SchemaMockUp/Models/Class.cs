using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Class
    {
        [Key]
        public int ClassID { get; set; }
        public int CourseID { get; set; } //fk
        public int UserID { get; set; } //fk
        public int EducatorUserID { get; set; } //fK
        public int Rating { get; set; }
        public bool IsVerified { get; set; }
    }
}
