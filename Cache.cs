using System;
using System.Collections.Generic;

namespace SessionDemo.GenericClass
{
    /// <summary>
    /// Generic Cache with expiration support
    /// </summary>
    public class Cache<TKey, TValue>
    {
        // Internal cache item with expiration
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
            public bool IsExpired => DateTime.Now >= ExpirationTime;
        }

        // Storage
        private Dictionary<TKey, CacheItem> _cache = new Dictionary<TKey, CacheItem>();
        private TimeSpan _defaultExpiration;

        // Constructor
        public Cache(TimeSpan defaultExpiration)
        {
            _defaultExpiration = defaultExpiration;
        }

        // Add item with default expiration
        public void Add(TKey key, TValue value)
        {
            Add(key, value, _defaultExpiration);
        }

        // Add item with custom expiration
        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            var item = new CacheItem
            {
                Value = value,
                ExpirationTime = DateTime.Now.Add(expiration)
            };

            _cache[key] = item;
        }

        // Get item (returns default if expired or not found)
        public TValue Get(TKey key)
        {
            if (key == null)
                return default(TValue);

            if (_cache.TryGetValue(key, out CacheItem item))
            {
                if (!item.IsExpired)
                    return item.Value;
                else
                    _cache.Remove(key); // Clean up expired item
            }

            return default(TValue);
        }

        // Remove item
        public bool Remove(TKey key)
        {
            if (key == null)
                return false;

            return _cache.Remove(key);
        }

        // Contains (checks if key exists and is not expired)
        public bool Contains(TKey key)
        {
            if (key == null)
                return false;

            if (_cache.TryGetValue(key, out CacheItem item))
            {
                if (!item.IsExpired)
                    return true;
                else
                    _cache.Remove(key); // Clean up expired item
            }

            return false;
        }

        // Clear all items
        public void Clear()
        {
            _cache.Clear();
        }

        // Get count of active (non-expired) items
        public int Count
        {
            get
            {
                CleanExpiredItems();
                return _cache.Count;
            }
        }

        // Clean expired items
        private void CleanExpiredItems()
        {
            List<TKey> keysToRemove = new List<TKey>();
            foreach (var kvp in _cache)
            {
                if (kvp.Value.IsExpired)
                    keysToRemove.Add(kvp.Key);
            }

            foreach (var key in keysToRemove)
            {
                _cache.Remove(key);
            }
        }
    }
}