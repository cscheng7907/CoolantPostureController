using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerSuperIO.Modbus.Common
{
    internal static class SequenceUtility
    {
        public static IEnumerable<T> Slice<T>(this IEnumerable<T> source, int startIndex, int size)
        {
            if (source == null)
            {
                //by cs
                //throw new ArgumentNullException(nameof(source));
                return null;
            }

            var enumerable = source as T[] ?? source.ToArray();
            int num = enumerable.Count();

            if (startIndex < 0 || num < startIndex)
            {
                //by cs 
                //throw new ArgumentOutOfRangeException(nameof(startIndex));
                return null;
            }

            if (size < 0 || startIndex + size > num)
            {
                //by cs 
                //throw new ArgumentOutOfRangeException(nameof(size));
                return null;
            }

            return enumerable.Skip(startIndex).Take(size);
        }
    }
}
