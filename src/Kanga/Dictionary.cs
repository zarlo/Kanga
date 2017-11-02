using System;
using System.Collections.Generic;
using System.Text;

namespace Kanga
{
    public class Dictionary<TKey, TValue>
    {


        public List<TKey> Key;
        public List<TValue> Value;

        public Dictionary()
        {
            Key = new List<TKey>();
            Value = new List<TValue>();
        }

        public TValue this[TKey val]
        {
            get
            {
                return GetValue(val);
            }
            set
            {
                SetValue(val, value);
            }

        }

        internal TValue GetValue(TKey key)
        {

            for (int i = 0; i < Value.Count; i++)
            {
                if(Key[i].Equals(key))
                return Value[i];

            }

            return default(TValue);
        }

        internal void SetValue(TKey key, TValue value)
        {

            for (int i = 0; i < Value.Count; i++)
            {
                if (Key[i].Equals(key))
                {

                    Value[i] = value;
                    break;
                }
            }
            
        }

        public bool TryGetValue(TKey key, out TValue current)
        {
            TValue temp = GetValue(key);

            if (temp.Equals(default(TValue)))
            {
                current = default(TValue);
                return false;

            }
            else
            {

                current = GetValue(key);

                return true;
            }
            
        }

        public void Add(TKey key, TValue value)
        {
            Key.Add(key);
            Value.Add(value);
        }
    }
}
