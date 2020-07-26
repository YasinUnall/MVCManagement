using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCManagement.Models
{
    public class Employee
    {
        public short Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public byte Age { get; set; }
        public int Salary { get; set; }
    }
}