using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToSql_Samples.Helpers
{
    public class EmployeeHelper : BaseHelper
    {
        public static string getFirstName()
        {
            return getRandomString(20);
        }

        public static string getLastName()
        {
            return getRandomString(20);
        }

    }
}
