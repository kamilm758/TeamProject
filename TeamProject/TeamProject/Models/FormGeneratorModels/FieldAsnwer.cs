using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormGenerator.Models
{
    public class FieldAnswer
    {
        [Key]
        public int Id { get; set; }
        public int IdField { get; set; }
        public int IdAnswer { get; set; }
    }
}
