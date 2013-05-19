using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCode.Hypermedia
{
    public class HypermediaRel : IHypermediaRel
    {
        #region IHypermediaRel Members

        public string Name
        {
            get;
            set;
        }

        public Type Type
        {
            get;
            set;
        }

        #endregion IHypermediaRel Members
    }
}