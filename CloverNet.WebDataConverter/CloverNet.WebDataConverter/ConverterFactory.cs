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
        public static IConverter GetService(Type type)
        {
            if (typeof(IConverter).IsAssignableFrom(type))
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
