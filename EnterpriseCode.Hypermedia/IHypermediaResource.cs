using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EnterpriseCode.Hypermedia
{
    public interface IHypermediaResource
    {
        [JsonProperty(Required = Required.Always, PropertyName = "links")]
        ICollection<IHypermediaLink> Links { get; set; }
    }
}