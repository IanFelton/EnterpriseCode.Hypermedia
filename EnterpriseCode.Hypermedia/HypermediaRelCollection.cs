using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCode.Hypermedia
{
    public class HypermediaRelCollection
    {
        private ICollection<IHypermediaRel> hypermediaRelCollection;

        public ICollection<IHypermediaRel> Rels { get; set; }

        public HypermediaRelCollection(ICollection<IHypermediaRel> collection)
        {
            this.hypermediaRelCollection = collection;
        }
    }
}