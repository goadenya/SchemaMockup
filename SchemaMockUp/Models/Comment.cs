using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public Post Post { get; set; } //FK
        public User User { get; set; } //FK
        public string UserComment { get; set; }
        public int Likes { get; set; }
        public DateTime Date { get; set; }
    }
}
