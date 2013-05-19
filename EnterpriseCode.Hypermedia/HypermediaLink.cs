﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCode.Hypermedia
{
    public class HypermediaLink : IHypermediaLink
    {
        public string Href { get; set; }

        public string Rel { get; set; }

        public string Schema
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Method
        {
            get;
            set;
        }
    }
}