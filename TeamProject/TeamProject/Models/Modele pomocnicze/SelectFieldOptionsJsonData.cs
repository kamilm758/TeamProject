using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.Modele_pomocnicze
{
    public class SelectFieldOptionsJsonData
    {
        [JsonProperty("wartosc")]
        public string Wartosc { get; set; }
    }
}
