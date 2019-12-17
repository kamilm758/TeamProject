using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Models
{
    public class MyUser : IdentityUser
    {
        [PersonalData,Required]
        public string FirstName { get; set; }
        [PersonalData,Required]
        public string LastName { get; set; }

        public int CustomID { get; set; }
    }
}
