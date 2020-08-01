using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCManagement.Models
{
    public class Product
    {
        [Key]
        public short ProductID { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public short SupplierID { get; set; }
        [Required]
        public short CategoryID { get; set; }

        [Required]
        public string QuantityPerUnit { get; set; }
        [Required]
        public string UnitPrice { get; set; }
        [Required]
        public int InitsInStock { get; set; }
        [Required]
        public int UnitsOnOrder { get; set; }

        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}