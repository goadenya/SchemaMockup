using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class Skill
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<JobSkill> jobSkills { get; set; } = new List<JobSkill>();
    }
}
