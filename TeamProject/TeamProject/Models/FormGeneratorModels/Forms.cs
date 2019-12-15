using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FormGenerator.Models
{
    public class Forms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int id_Category { get; set; }
       
        public string Name { get; set; }
        
    }

    public class formsModel
    {
       public  Forms form;
        public IEnumerable<Forms> Dzieci;
    }
}
