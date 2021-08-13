using System;

namespace HoweFramework.Pool
{
    public class KeyPool<TKey> : IKeyPool<TKey>
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Pop<T>(TKey key, Func<TKey, T> factory = null) where T : class
        {
            throw new NotImplementedException();
        }

        public void Push<T>(TKey key, T value) where T : class
        {
            throw new NotImplementedException();
        }
    }
}