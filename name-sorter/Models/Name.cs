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
            //This helps clean up names that may have leading or trailing spaces.

            var nameParts = fullName.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2 || nameParts.Length > 4) // Set limit for names number
                throw new ArgumentException("A name must have 1–3 given names and a last name.");

            LastName = nameParts.Last(); //set the last element of a collection as last name.
            GivenNames  = nameParts.Take(nameParts.Length - 1).ToList();  // Select elements of collection but exclude the last one
        }

        public override string ToString() => string.Join(" ", GivenNames.Append(LastName));

       



    }
}
