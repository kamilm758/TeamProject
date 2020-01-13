using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.NewTypeAndValidation
{
    public class Validation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idValidation { get; set; }
        public int idField { get; set; }
        public string type { get; set; }
        public decimal? value { get; set; }
    }
}
