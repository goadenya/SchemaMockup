using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Post
    {
        [Key]
        public int ID { get; set; } //Pk
        [ForeignKey("ID")]
        public User User { get; set; } //Fk
        public string Description { get; set; }
        public int Likes { get; set; }
        public string Body { get; set; }
        public string MediaUrl { get; set; }
        public DateTime Date { get; set; }
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();
 
    }
}
