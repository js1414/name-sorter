using name_sorter.Model;
using name_sorter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Services
{
    public class NameSorter : INameSorter
    {
        public IEnumerable<Name> Sort(IEnumerable<Name> names)
        {
            return names
                .OrderBy(n => n.LastName)
                .ThenBy(n => string.Join(" ", n.GivenNames))
                .ToList();
        }
    }
}
