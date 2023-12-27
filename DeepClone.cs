using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DeepClone
    {


        #region properties
        private TKey key;
        private TValue value;

        public TKey Key
        {
            get { return key; }
            set
            {
                key = value;
                OnPropertyChanged("Key");
            }
        }

        
        #endregion
    }
}
