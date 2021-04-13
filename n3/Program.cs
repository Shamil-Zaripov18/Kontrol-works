using System;
using System.Collections.Generic;
using System.Linq;


namespace n3
{
    class Program
    {
        public static object Dictionaries { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, double> Dictionary = new Dictionary<string, double>();
            for (int i = 0; i < Dictionaries.Length; i++)
            {
                foreach (var item in Dictionaries[i]) 
                { if (Dictionary.ContainsKey(item.Key)) 
                    { Dictionary[item.Key] = Math.Max(item.Value, Dictionary[item.Key]); 
                     } 
                    else
                    
                    { Dictionary.Add(item.Key, item.Value);
                   }
                }
            }
            return Dictionary;
        }
    }
}
