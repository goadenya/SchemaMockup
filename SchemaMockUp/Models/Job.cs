using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Job
    {
        [Key]
        public int JobID { get; set; }
        public int CompanyUserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public bool IsVisible { get; set; }

    }
}
