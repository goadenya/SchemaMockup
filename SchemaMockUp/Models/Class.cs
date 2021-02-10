using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Class
    {
        [Key]
        public int ClassID { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; } //fk
        public List<User> Users { get; set; } //fk
        public List<User> Educators{ get; set; } //fK
        public int Rating { get; set; }
        public bool IsVerified { get; set; } = false;
    }
}
