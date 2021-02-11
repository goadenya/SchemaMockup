using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Education
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public School School { get; set; } //FK
        public string Name { get; set; } // Two names?
        public string Period { get; set; } //Hur???? Start/End date
        public int Points { get; set; }
        public bool IsLiaCourses { get; set; }
        public string City { get; set; }

    }
}
