using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class SkillMatch
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Skill Skill { get; set; } //Fk
        [ForeignKey("ID")]
        public User User { get; set; } //Fk
        public bool IsVerified { get; set; } = false;
        public DateTime Created { get; set; }
    }
}
