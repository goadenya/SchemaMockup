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
        public int CommentID { get; set; }
        public Post Post { get; set; } //FK  
        [ForeignKey("Post")]
        public int PostID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; } //FK
        public string UserComment { get; set; }
        public int Likes { get; set; }
        public DateTime Date { get; set; }
    }
}
