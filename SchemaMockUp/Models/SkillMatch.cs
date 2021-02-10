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
        public int SkillMatchID { get; set; }
        [ForeignKey("Skill")]
        public int SkillID { get; set; }
        public Skill Skill { get; set; } //Fk
        [ForeignKey("User")]
        public int UserID { get;  set; }
        public User User { get; set; } //Fk
        public bool IsVerified { get; set; }
        public DateTime Created { get; set; }
    }
}
