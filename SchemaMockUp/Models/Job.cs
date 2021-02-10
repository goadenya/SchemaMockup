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
        public int JobID { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public int CompanyUserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public bool IsVisible { get; set; } = false;

        public List<JobSkill> JobSkills { get; set; } = new List<JobSkill>();

    }
}
