using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloverNet.WebDataConverter
{
    public interface IConverter
    {
        string Convert<T, V>(IDictionary<T, V> data);
    }
}
