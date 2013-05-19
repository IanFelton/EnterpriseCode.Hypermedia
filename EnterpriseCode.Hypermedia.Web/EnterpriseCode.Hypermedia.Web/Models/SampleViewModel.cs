using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EnterpriseCode.Hypermedia.Web.Models
{
    public class SampleViewModel : HypermediaResource
    {
        #region IHypermediaResource Members

        [JsonProperty(Required = Required.Always, PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(Required = Required.Always, PropertyName = "address")]
        public string Address { get; set; }

        public ICollection<IHypermediaLink> Links
        {
            get;
            set;
        }

        #endregion IHypermediaResource Members
    }
}