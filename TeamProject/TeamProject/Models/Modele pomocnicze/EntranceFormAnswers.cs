
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormGenerator.Models.Modele_pomocnicze
{
    public class EntranceFormAnswers
    {
        public int IdField { get; set; }
        public int IdPatient { get; set; }

        public string Name { get; set; }
        public bool Answer { get; set; }



    }
}