//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpDetails.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpRole
    {
        public EmpRole()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int Role_ID { get; set; }
        public string Role_Name { get; set; }
        public int Salary { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
