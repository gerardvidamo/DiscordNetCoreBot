using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscordBot.Common
{
    public static class PropertyInfoHelper
    {
        public static IEnumerable<KeyValuePair<string,string>> StringProperties(object obj)
        {
            return from p in obj.GetType().GetProperties()
                    where p.PropertyType == typeof(string)
                    select new KeyValuePair<string,string>(p.Name, (string)p.GetValue(obj));
        }
        public static IEnumerable<KeyValuePair<string,T>> PropertiesOfType<T>(object obj)
        {
            return from p in obj.GetType().GetProperties()
                    where p.PropertyType == typeof(T)
                    select new KeyValuePair<string,T>(p.Name, (T)p.GetValue(obj));
        }
    }
}