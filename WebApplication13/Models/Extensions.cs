using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Models
{
    public static class Extensions
    {
        public static T GetOrNull<T>(this SqlDataReader reader, string column)
        {
            object value = reader[column];
            if (value == DBNull.Value)
            {
                return default(T);
            }
            return (T)value;
        }
    }
}
