using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class Appointment
    {
        [Key]
        public int ID { get; set; } 
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public string InvitationLink { get; set; }
        public double Duration { get; set; }
        public int CreatedByUserID  { get; set; }
        public virtual List<AppointmentParticipant> AppointmentParticipants { get; set; } = new List<AppointmentParticipant>();

        //Appointment kan ha många participants?
    }
}
