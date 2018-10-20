using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseKeyValues
{
    class MyDictionary
    {
        KeyValue[] Array = new KeyValue[60];
        private int Counter = 1;
        public Object this[string Key1]
        {
            get
            {
                if (Counter < 1)
                {
                    throw new KeyNotFoundException();
                }
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i].Key == Key1)
                    {
                        return Array[i].Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                bool isRelevant = false;
                for (int i = 0; i < Counter; i++)
                {
                    if (Array[i].Key == Key1)
                    {
                        Array[i] = new KeyValue(Key1, Array[i].Value);
                        isRelevant = true;
                    }
                }
                if (!isRelevant)
                {
                    Array[Counter + 1] = new KeyValue(Key1, value);
                }
                Counter++;
            }
        }
    }
}
