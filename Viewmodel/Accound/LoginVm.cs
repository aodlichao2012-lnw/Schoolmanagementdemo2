using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Viewmodel.Accound
{
    public class LoginVm
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required , DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Rememberme { get; set; }
    }
}
