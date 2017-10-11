using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemove1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> adlar = new List<string> {"tural","Nicat","Yasin","Hafiz","Muzeyyen","Yasin", "Tural", "nicat"};
            adlar.Sort();
          
            var kopyalar = adlar.Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
            

            foreach (string item in kopyalar)
            {
                Console.WriteLine(item.First().ToString().ToUpper() + item.Substring(1));
            }

            

            


        }
        
        
    }
}
