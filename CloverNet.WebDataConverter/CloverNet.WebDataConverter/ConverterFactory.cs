using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CloverNet.WebDataConverter
{
    public class ConverterFactory
    {
        public static IConverter GetService(Type type) {

            if (type.IsDefined(typeof(IConverter)))
            {
                return (IConverter)Activator.CreateInstance(type);
            }

            return null;
        }

        public static IConverter GetService<T>()
        {
            return GetService(typeof(T));
        }

    }
}
