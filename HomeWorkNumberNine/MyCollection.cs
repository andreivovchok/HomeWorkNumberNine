using System;
using System.Collections.Generic;

namespace HomeWorkNumberNine
{
    public class MyCollection<T>
    {
        private List<T> _collection = new List<T>();

        public void Add(T value)
        {
            _collection.Add(value);
        }
        public T this[int i]
        {
            get { return _collection[i]; }
        }
        public int Count 
        {
            get { return _collection.Count; } 
        }
    }
}
