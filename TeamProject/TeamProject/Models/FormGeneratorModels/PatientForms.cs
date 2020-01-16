﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormGenerator.Models
{
    public class PatientForms
    {
        [Key]
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdForm { get; set; }
        public Boolean? agreement { get; set; }
    }
}
