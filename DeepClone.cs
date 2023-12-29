using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DeepClone
    {


        


        public bool Remove(TKey key)
        {
            var remove = ThisAsCollection().Where(pair => Equals(key, pair.Key)).ToList();
            foreach (var pair in remove)
            {
                ThisAsCollection().Remove(pair);
            }
            return remove.Count > 0;
        }

        #endregion
    }
}
