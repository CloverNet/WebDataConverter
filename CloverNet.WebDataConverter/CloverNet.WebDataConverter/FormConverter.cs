using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverNet.WebDataConverter
{
    public class FormConverter : IConverter
    {
        public string Convert<T, V>(IDictionary<T, V> data)
        {
            return data.Select(m => $"<input type='hidden' name='{m.Key}' value ='{m.Value}'/>").Aggregate((m, n) => m + n);
        }
    }
}
