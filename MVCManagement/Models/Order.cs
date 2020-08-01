using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCManagement.Models
{
    public class Order
    {
        [Key]
        public short OrderID { get; set; }

        [Required][Column(Order=1)]
        public int CustomerID { get; set; }
        [Required][Column(Order = 2)]
        public short EmployeeID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public short ShipVia { get; set; }
        [Required]
        public string ShipAddress { get; set; }

        
        public ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
