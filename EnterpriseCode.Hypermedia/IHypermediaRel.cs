using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCode.Hypermedia
{
    public interface IHypermediaRel
    {
        string Name { get; set; }

        Type Type { get; set; }
    }
}