using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseKeyValues
{
    public struct KeyValue
    {
        public string Key;
        public object Value;
        
        public KeyValue(string Key, object Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, { (int)d["Dogs"]}");
        }
    }
}
