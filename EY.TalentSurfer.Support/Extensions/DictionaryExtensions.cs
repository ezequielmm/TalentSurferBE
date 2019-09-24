using System;
using System.Collections.Generic;
using System.Linq;

namespace EY.TalentSurfer.Support.Extensions
{
    public static class DictionaryExtensions
    {
        public static void MergeDictionaryWith<TKey, TValue>(this IDictionary<TKey, TValue> origin, IDictionary<TKey, TValue> dictionary)
        {
            foreach (KeyValuePair<TKey, TValue> item in dictionary)
            {
                origin[item.Key] = item.Value;
            }
        }

        public static void DeleteItems<TKey, TValue>(this IDictionary<TKey, TValue> origin, IEnumerable<TKey> keys, bool ignoreCase = true)
        {
            if (keys == null)
            {
                throw new ArgumentNullException(nameof(keys));
            }

            foreach (var item in keys)
            {
                if (ignoreCase ? origin.ContainsKeyIgnoreCase(item) : origin.ContainsKey(item)) {
                    origin.Remove(ignoreCase ? origin.GetActualKey(item) : item);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(item.ToString());
                }
            }
        }

        public static bool ContainsKeyIgnoreCase<TKey, TValue>(this IDictionary<TKey, TValue> target, TKey value)
        {
            return target.Any(x => string.Compare(x.Key.ToString(), value.ToString(), StringComparison.InvariantCultureIgnoreCase) == 0);
        }

        public static TKey GetActualKey<TKey, TValue>(this IDictionary<TKey, TValue> target, TKey value)
        {
            return target.Keys.FirstOrDefault(x => string.Compare(x.ToString(), value.ToString(), StringComparison.InvariantCultureIgnoreCase) == 0);
        }
    }
}
