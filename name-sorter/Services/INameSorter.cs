using name_sorter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Service
{
    public interface INameSorter
    {
        IEnumerable<Name> Sort(IEnumerable<Name> names);

    }
}
