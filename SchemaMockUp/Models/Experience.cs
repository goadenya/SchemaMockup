using System;
using System.Collections.Generic;
using System.Text;

namespace testdbbConsole.Models
{
    class Experience
    {
        public int ExperienceID { get; set; }
        public string Name { get; set; }
        public string ExperienceLevel { get; set; }
        public bool IsVerified { get; set; }
        public bool VerifiedByOrganizerID { get; set; }
    }
}
