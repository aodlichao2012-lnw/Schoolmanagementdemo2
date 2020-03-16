using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Viewmodel.Accound
{
    public class RegisterVM
    {
        
        public string Username { get; set; }
        [Required , DataType(DataType.Password)]
        public string password { get; set; }
        [Required ,DataType(DataType.Password)]
        [Compare("password")]
        public string confirmPassword { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
