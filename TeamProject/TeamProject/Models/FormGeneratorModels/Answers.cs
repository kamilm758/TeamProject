using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models.FormGeneratorModels
{
    public class Answers
    {
        [Key]
        public int Id { get; set; }
        public string Answer { get; set; }
    }
}
