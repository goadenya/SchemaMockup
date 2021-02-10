using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class JobSkill
    {
        [Key]
        public int JobSkillID { get; set; }
        
        public Skill Skill { get; set; }
        [ForeignKey("Skill")]
        public int SkillID { get; set; } //FK
        
        public Job Job { get; set; }
        [ForeignKey("Job")]
        public int JobID { get; set; } //FK
    }
}
