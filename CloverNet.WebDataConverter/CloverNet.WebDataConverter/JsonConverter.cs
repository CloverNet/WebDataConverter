using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverNet.WebDataConverter
{
    public class JsonConverter : IConverter
    {
        public string Convert<T, V>(IDictionary<T, V> data)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
        }
    }
}
