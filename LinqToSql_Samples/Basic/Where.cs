using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LinqToSql_Samples.Basic
{
    public class Where : BasicSample
    {

        public void Run()
        {
            var allEmployees = dbContext.Employee.Where(e => e.Contract.Product == 1).Include(e => e.Contract).ThenInclude(c => c.ProductNavigation).ToList();

            foreach (var employee in allEmployees)
            {
                Console.WriteLine(employee.ToString() + " Product: " + employee.Contract.ProductNavigation.Name);
            }
        }
    }
}
