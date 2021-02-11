using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Rating
    {
        public int ID { get; set; }
        [ForeignKey("ID")]
        public User User { get; set; }
        public string CompanyName { get; set; } //??? user?
        public string OrganizerName { get; set; } //??User?
        [Column("Rating")]
        public int UserRating { get; set; }
        public bool Verified { get; set; } = false;
        public string Comment { get; set; }

    }
}