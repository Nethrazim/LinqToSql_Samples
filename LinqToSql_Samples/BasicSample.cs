using LinqToSql_Samples.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToSql_Samples
{
    public class BasicSample
    {
        protected LinqToSqlContext dbContext { get; set; }
        public BasicSample()
        {
            dbContext = new LinqToSqlContext();
        }
    }
}
