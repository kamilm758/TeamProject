using FormGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Models.NewTypeAndValidation;

namespace TeamProject.Models.Modele_pomocnicze
{
    public class NewFieldList
    {
        [Key]
        public int FormId { get; set; }
        public IList<FieldWithValidation> fields { get; set; } = new List<FieldWithValidation>();
        public string currentName { get; set; }
        public string currentType { get; set; }
        public int currentId { get; set; }
        public string currentNameToCreate { get; set; }
        public string currentTypeToCreate { get; set; }
        //ograniczenie
        public string minString { get; set; }
        public Validation min { get; set; } = new Validation();
        public string maxString { get; set; }
        public Validation max { get; set; } = new Validation();
        public Validation integerVal { get; set; } = new Validation();
        //select
        public List<SelectFieldOptions> optionsToCurrentField { get; set; } = new List<SelectFieldOptions>();
        public string currentOption { get; set; }
    }
}
