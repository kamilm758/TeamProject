using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.NewTypeAndValidation
{
    public class SelectFieldOptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idOption { get; set; }
        public int idField { get; set; }
        public string option { get; set; }
    }
}
