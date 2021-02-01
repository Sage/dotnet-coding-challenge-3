namespace sage.challenge.data.Cache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SimpleObjectCache<TKey, TValue> : ISimpleObjectCache<TKey, TValue>
    where TKey : struct
    where TValue : class
    {
        private static Lazy<Dictionary<TKey, TValue>> _cacheInstance = new Lazy<Dictionary<TKey, TValue>>(() => new Dictionary<TKey, TValue>());

        public Task AddAsync(TKey key, TValue value)
        {
            _cacheInstance.Value.TryAdd(key, value);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(TKey key)
        {
            _cacheInstance.Value.Remove(key, out TValue value);
            return Task.CompletedTask;
        }

        public Task<TValue> GetAsync(TKey key)
        {
            return Task.FromResult(_cacheInstance.Value.ContainsKey(key) ? _cacheInstance.Value[key] : default(TValue));
        }

        public Task<IEnumerable<TValue>> GetAllAsync()
        {
            IEnumerable<TValue> values = _cacheInstance.Value.Values.ToList();
            return Task.FromResult(values);
        }

        public Task UpdateAsync(TKey key, TValue value)
        {
            if (_cacheInstance.Value.ContainsKey(key))
                _cacheInstance.Value[key] = value;
            return Task.CompletedTask;
        }
    }

}
