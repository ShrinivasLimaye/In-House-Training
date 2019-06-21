using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDetails.Models
{
    public class EmpEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Contact { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Dept_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}