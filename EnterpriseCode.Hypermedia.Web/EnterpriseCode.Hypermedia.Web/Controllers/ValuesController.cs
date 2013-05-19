using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnterpriseCode.Hypermedia.Web.Models;
using Newtonsoft.Json.Schema;

namespace EnterpriseCode.Hypermedia.Web.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            var model = new SampleViewModel();
            model.Address = "700 Dougals Ave.";
            model.Id = 1;
            var linksCollection = new List<IHypermediaLink>();
            model.Links = linksCollection;
            model.Links.Add(new HypermediaLink { Rel = "self", Href = "http://this.com/sampleViewModel" });
            model.Links.Add(new HypermediaLink { Rel = "new", Href = "http://this.com/sampleViewModel/new" });
            response = Request.CreateResponse(HttpStatusCode.OK, model);

            return response;
        }
    }
}