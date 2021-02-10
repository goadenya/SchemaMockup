using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string Name { get; set; }

    }
}
