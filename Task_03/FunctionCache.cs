using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class FunctionCache<TKey, TResult>
    {
        public delegate TResult FuncDelegate(TKey key);

        private Dictionary<TKey, Tuple<TResult, DateTime>> cache = new Dictionary<TKey, Tuple<TResult, DateTime>>();

        public TResult GetOrAdd(TKey key, FuncDelegate function, TimeSpan cacheDuration)
        {
            if (cache.TryGetValue(key, out var cachedValue) && IsCacheValid(cachedValue.Item2, cacheDuration))
                return cachedValue.Item1;

            TResult result = function(key);
            cache[key] = Tuple.Create(result, DateTime.Now);
            return result;
        }

        private bool IsCacheValid(DateTime cachedTime, TimeSpan cacheDuration) => DateTime.Now - cachedTime <= cacheDuration;

        internal int GetOrAdd(string key, Func<string, int> expensiveFunction, TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }
    }
}
