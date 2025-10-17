using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Service
{
    public interface INameWriter
    {
        void WriteLine(IEnumerable<string> names);
    }
}
