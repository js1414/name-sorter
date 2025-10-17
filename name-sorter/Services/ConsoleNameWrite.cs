using name_sorter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Services
{
    public class ConsoleNameWriter : INameWriter
    {
        public void WriteLine(IEnumerable<string> names)
        {
            Console.WriteLine("-------Sorted name: ");
            foreach (var name in names)
                Console.WriteLine(name);
        }

        //Write sorted names to screen
      
    }
 }

