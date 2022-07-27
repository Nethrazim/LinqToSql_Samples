using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToSql_Samples.Models
{
    public partial class Employee
    {
        public override string ToString()
        {
            return $"FirstName: {FirstName} LastName: {LastName}";
        }
    }
}
