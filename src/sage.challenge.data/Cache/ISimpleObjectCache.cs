using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sage.challenge.data.Cache
{
    public interface ISimpleObjectCache<TKey, TValue>
    where TKey : struct
    where TValue : class
    {
        Task AddAsync(TKey key, TValue value);

        Task DeleteAsync(TKey key);

        Task<TValue> GetAsync(TKey key);

        Task<IEnumerable<TValue>> GetAllAsync();

        Task UpdateAsync(TKey key, TValue value);
    }
}
