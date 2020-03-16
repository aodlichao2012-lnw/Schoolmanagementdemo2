using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_commere.Models
{
    public class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderLines = new HashSet<OrderLine>();
        }
        
        public Product(int productid, string productName, string details, decimal unitPrice, bool isActive, FormFile productImage, string productImagepath)
        {
            this.Productid = productid;
            this.ProductName = productName;
            this.Details = details;
            this.UnitPrice = unitPrice;
            this.IsActive = isActive;
            this.ProductImage = productImage;
            this.ProductImagepath = productImagepath;

        }
        public int Productid { get; set; }
        [Required, Display(Name = "Productname")]
        public string ProductName { get; set; }
        public string Details { get; set; }
        public decimal UnitPrice { get; set; }
        public int? Unitinstock { get; set; }
        public bool IsActive { get; set; }
        [NotMapped]
        public FormFile ProductImage { get; set; }
        public string ProductImagepath { get; set; }
        public int? Categoryid { get; set; }
        public int? Pictureid { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }

    }
}
