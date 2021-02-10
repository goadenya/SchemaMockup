using System;
using System.Collections.Generic;
using System.Text;

namespace testdbbConsole.Models
{
    class Post
    {
        public int PostID { get; set; } //Pk
        public User User { get; set; } //Pk
        public string Description { get; set; }
        public int Likes { get; set; }
        public string Body { get; set; }
        public string MediaUrl { get; set; }
        public DateTime Date { get; set; }

    }
}
