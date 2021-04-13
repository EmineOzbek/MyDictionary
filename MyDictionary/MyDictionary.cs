using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey _key, TValue _value) 
        {
            TKey[] tempKeys = _keys;
            TValue[] tempValues = _values;
            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }
            
            _keys[_keys.Length - 1] = _key;
            _values[_values.Length - 1] = _value;

        }

        public int Count 
        {
            get { return _keys.Length; }
        }
        
        public TKey[] Keys
        {
            get { return _keys; }
        }

        public TValue[] Values
        {
            get { return _values; }
        }

    }
}
