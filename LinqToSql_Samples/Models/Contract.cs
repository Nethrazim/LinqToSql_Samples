using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LinqToSql_Samples.Models
{
    public partial class Contract
    {
        public Contract()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public DateTime SignedDate { get; set; }
        public int Product { get; set; }

        public virtual Product ProductNavigation { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
