using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace MovieSite.Data.Infrastructure
{
	public interface IKaching
	{
		T Get<T>(string key) where T : class;
		void Add<T>(T objectToCache, string key) where T : class;
		void Clear(string key);
		bool Exists(string key);
		List<string> GetKeys();
	}

	public class Kaching : IKaching // I'm sure I'm not the first to use this pun, but it's the first time I'VE used it.
	{
		private readonly ObjectCache _cache = MemoryCache.Default;

		public T Get<T>(string key) where T : class
		{
			if (!Exists(key)) return null;
			var obj = _cache[key] as T;
			return obj;
		}

		public void Add<T>(T objectToCache, string key) where T : class
		{
			_cache.Add(key, objectToCache, DateTime.Now.AddHours(6));
		}

		public void Clear(string key)
		{
			_cache.Remove(key);
		}

		public bool Exists(string key)
		{
			return _cache.Get(key) != null;
		}

		public List<string> GetKeys()
		{
			return _cache.Select(keyValuePair => keyValuePair.Key).ToList();
		}
	}
}
