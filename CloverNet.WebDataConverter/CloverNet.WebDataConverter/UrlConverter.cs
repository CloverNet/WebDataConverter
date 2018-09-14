using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverNet.WebDataConverter
{
    public class UrlConverter : IConverter
    {
        public string Convert<T, V>(IDictionary<T, V> data)
        {
            return data.Select(m => m.Key + "=" + m.Value).Aggregate((m, n) => m + "&" + n);
        }

    }
}
