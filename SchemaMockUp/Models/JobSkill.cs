﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaMockUp.Models
{
    class JobSkill
    {
        public int SkillID { get; set; } //FK
        public int jobID { get; set; } //FK
    }
}
