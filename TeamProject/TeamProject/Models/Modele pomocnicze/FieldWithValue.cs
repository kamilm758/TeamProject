
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Models.FieldDependencyModels;
using TeamProject.Models.NewTypeAndValidation;

namespace FormGenerator.Models.Modele_pomocnicze
{
    public class FieldWithValue
    {
        public Field Field { get; set; } = new Field();
        public string TextValue { get; set; }
        public bool BoolValue { get; set; }
        public FieldFieldDep fieldFieldDep { get; set; } = new FieldFieldDep();
        public FieldFieldDependency Dependencies { get; set; } = new FieldFieldDependency();
        public List<SelectFieldOptions> options { get; set; } = new List<SelectFieldOptions>();

    }
}