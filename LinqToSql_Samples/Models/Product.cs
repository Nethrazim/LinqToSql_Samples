using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LinqToSql_Samples.Models
{
    public partial class Product
    {
        public Product()
        {
            Contract = new HashSet<Contract>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
    }
}
