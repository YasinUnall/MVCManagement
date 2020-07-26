using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCManagement.Models
{
    public class Product
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public int InitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}