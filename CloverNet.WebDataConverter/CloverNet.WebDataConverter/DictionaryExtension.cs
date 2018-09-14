using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverNet.WebDataConverter
{
    public static class DictionaryExtension
    {
        public static IDictionary<string, string> ToDictionary(this NameValueCollection collection)
        {
            return collection.AllKeys.ToDictionary(m => m, m => collection[m]);
        }

        public static IDictionary<T, V> ToDictionary<T,V>(this ICollection collection, Func<object,T> keySelector ,Func<object, V> valueSelector)
        {
            var result = new Dictionary<T, V>();

            foreach (var item in collection)
            {
                result.Add(keySelector(item), valueSelector(item));
            }

            return result;
        }
    }
}
