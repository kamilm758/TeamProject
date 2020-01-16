using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.NewTypeAndValidation
{
    public class FieldWithValidation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Validation> validations { get; set; } = new List<Validation>();
        public List<SelectFieldOptions> options { get; set; } = new List<SelectFieldOptions>();
    }
}
