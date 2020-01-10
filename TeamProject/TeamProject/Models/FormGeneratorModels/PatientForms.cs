using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.FormGeneratorModels
{
    public class PatientForms
    {
        public int IdPatient { get; set; }
        public int IdForm { get; set; }
        public Boolean? agreement { get; set; }
    }
}
