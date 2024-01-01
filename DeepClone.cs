using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DeepClone
    {


        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue);
            var r = GetKvpByTheKey(key);
            if (!Equals(r, default(ObservableKeyValuePair<TKey, TValue>)))
            {
                return false;
            }
            value = r.Value;
            return true;
        }


        public bool Remove(TKey key)
        {
            var remove = ThisAsCollection().Where(pair => Equals(key, pair.Key)).ToList();
            foreach (var pair in remove)
            {
                ThisAsCollection().Remove(pair);
            }
            return remove.Count > 0;
        }

        


    }

}
