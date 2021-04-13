using System;
using System.Linq;
using System.Collections.Generic;


namespace n2
{
    class Program
    {
        
        private static void Generation()
        {
            List<double> list = new List<double> { 2.14, 7.94, 8.01, 8.64, 9.18, 10.23, 13.67 };
            Console.WriteLine(string.Join("\t", list.Select(x => x.ToString())));

            List<double> newList = gener(list);
            Console.WriteLine(string.Join("\t", newList.Select(x => x.ToString())));

        }
        private static List<double> gener(List<double> list)
        {
            var total = new List<double>();
            var VrS = new List<double>();
            for (var i = 0; i < list.Count; i++)
            {
                VrS = list.GetRange(0, i + 1);
                var sum = VrS.Sum();
                total.Add(sum);
            }

            return total;
        }
        static void Main(string[] ars)
        {
            Generation();
        }
    }
}
