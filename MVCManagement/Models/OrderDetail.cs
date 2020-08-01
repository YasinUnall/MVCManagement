using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCManagement.Models
{
    public class OrderDetail
    {
        [Key][Column(Order=0)]
        [ForeignKey("Order")]
        public short OrderID { get; set; }

        [Key][Column(Order = 1)]
        [ForeignKey("Product")]
        public short ProductID { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public short Quantity { get; set; }

        public double Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}