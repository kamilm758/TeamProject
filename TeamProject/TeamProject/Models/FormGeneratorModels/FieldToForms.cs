using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.FormGeneratorModels
{
    public class FieldToForms
    {
        [Key]
        public int Id { get; set; }
        public int IdForm { get; set; }
        public int IdField { get; set; }
        public string expectedAnswer { get; set; }
    }
}
