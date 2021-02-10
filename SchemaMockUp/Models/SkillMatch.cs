using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class SkillMatch
    {
        [Key]
        public int SkillMatchID { get; set; }
        public Skill Skill { get; set; } //Fk
        public User User { get; set; } //Fk
        public bool IsVerified { get; set; }
        public DateTime Created { get; set; }
    }
}
