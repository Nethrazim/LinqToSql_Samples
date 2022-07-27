using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToSql_Samples.Helpers
{
    public class BaseHelper
    {
        private static Random random = new Random();
        public static string getRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
