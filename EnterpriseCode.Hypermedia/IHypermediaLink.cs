using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EnterpriseCode.Hypermedia
{
    public interface IHypermediaLink
    {
        [JsonProperty(Required = Required.Always, PropertyName = "href")]
        string Href { get; set; }

        [JsonProperty(Required = Required.Always, PropertyName = "rel")]
        string Rel { get; set; }

        [JsonProperty(Required = Required.Default, PropertyName = "schema")]
        string Schema { get; set; }

        [JsonProperty(Required = Required.Default, PropertyName = "title")]
        string Title { get; set; }

        [JsonProperty(Required = Required.Default, PropertyName = "method")]
        string Method { get; set; }
    }
}