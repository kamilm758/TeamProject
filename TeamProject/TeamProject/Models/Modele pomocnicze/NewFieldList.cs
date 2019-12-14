using FormGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.Modele_pomocnicze
{
    public class NewFieldList
    {
        [Key]
        public int FormId { get; set; }
        public IList<Field> fields { get; set; } = new List<Field>();
    }
}
