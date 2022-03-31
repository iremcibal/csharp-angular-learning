using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Tkey , Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary() { 
            keys = new Tkey[0];
            values = new Tvalue[0];

        } //Default Constructor
        
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempArray1 = keys;
            Tvalue[] tempArray2 = values;

            keys = new Tkey[keys.Length+1];
            values = new Tvalue[keys.Length+1];

            for(int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
                values[i] = tempArray2[i];
            }

            keys[keys.Length-1] = key;
            values[keys.Length-1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }

        
    }
}
