using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.FormGeneratorModels
{
    public class FieldToForms
    {
        public int IdForms { get; set; }
        public int IdField { get; set; }
        public string expectedAnswer { get; set; }
    }
}
