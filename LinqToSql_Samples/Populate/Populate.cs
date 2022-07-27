using LinqToSql_Samples.Helpers;
using LinqToSql_Samples.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqToSql_Samples.Populate
{
    public class Populate : BasicSample
    {
        public Random random = new Random();
        public void Run()
        {
            if (dbContext.Employee.Count() == 1)
            {
                List<Employee> employees = new List<Employee>();
                for (int i = 0; i < 10; i++)
                {
                    employees.Add(new Employee()
                    {
                        FirstName = EmployeeHelper.getFirstName(),
                        LastName = EmployeeHelper.getLastName(),
                        Contract = new Contract()
                        {
                            ProductNavigation = dbContext.Product.First(),
                            SignedDate = DateTime.Now
                        },
                        DepartmentId = random.Next(dbContext.Department.Max(x => x.Id) + 1)
                    });
                }

                dbContext.Employee.AddRange(employees);
                dbContext.SaveChanges();
            }
        }
    }
}
