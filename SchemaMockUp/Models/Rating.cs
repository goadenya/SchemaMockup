using System;
using System.Collections.Generic;
using System.Text;

namespace testdbbConsole.Models
{
    class Rating
    {
        public int UserID { get; set; }
        public string CompanyName { get; set; }
        public string OrganizerName { get; set; }
        public int URating { get; set; }
        public bool Verified { get; set; }
        public string Comment { get; set; }

    }
}