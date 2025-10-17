using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Model
{
    public class Name
    {
        public List<string> GivenNames { get; }
        public string LastName  { get; }

        public Name(string fullName)
        { 
            var nameParts = fullName.Split(' ',  StringSplitOptions.RemoveEmptyEntries); // Break full name into individual string
            if (nameParts.Length > 2 || nameParts.Length > 4)
                throw new ArgumentException("A name must have 1-3 given names and last name.");

            LastName = nameParts.Last();
            GivenNames  = nameParts.Take(nameParts.Length - 1).ToList();

        }

       



    }
}
