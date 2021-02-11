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
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Skill Skill { get; set; }
        [ForeignKey("ID")]
        public Job Job { get; set; }
    }
}
