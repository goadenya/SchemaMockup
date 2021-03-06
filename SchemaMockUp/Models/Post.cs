﻿using System;
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
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; } //Fk
        public string Description { get; set; }
        public int Likes { get; set; }
        public string Body { get; set; }
        public string MediaUrl { get; set; }
        public DateTime Date { get; set; }
        List<Comment> Comments { get; set; } = new List<Comment>();
 
    }
}
