using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Job
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public bool IsVisible { get; set; } = false;

        public virtual List<JobSkill> JobSkills { get; set; } = new List<JobSkill>();

    }
}
