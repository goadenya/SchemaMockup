using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Comment
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Post Post { get; set; } //FK  
        [ForeignKey("ID")]
        public User User { get; set; } //FK
        [Column("Comment")]
        public string UserComment { get; set; }
        public int Likes { get; set; }
        public DateTime Date { get; set; }
    }
}
