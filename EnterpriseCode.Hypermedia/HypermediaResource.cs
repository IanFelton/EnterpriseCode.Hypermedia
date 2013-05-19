using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCode.Hypermedia
{
    public class HypermediaResource : IHypermediaResource
    {
        #region IHypermediaResource Members

        ICollection<IHypermediaLink> IHypermediaResource.Links
        {
            get;
            set;
        }

        #endregion IHypermediaResource Members
    }
}