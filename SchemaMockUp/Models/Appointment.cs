using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Appointment
    {
        [Key]
        public int AppointmentID { get; set; } 
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public string InvitationLink { get; set; }
        public double Duration { get; set; }
        public int CreatedByUserID  { get; set; }
        public List<AppointmentParticipant> AppointmentParticipants { get; set; }

        //Appointment kan ha många participants?

    }
}
