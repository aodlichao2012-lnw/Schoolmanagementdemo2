using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    public class Customer : IdentityUser
    {
        public string Customername { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public int Postalcode { get; set; }
        public DateTime? DataEnters { get; set; }
    }
}
