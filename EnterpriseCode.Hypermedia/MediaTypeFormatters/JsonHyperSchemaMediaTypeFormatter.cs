using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace EnterpriseCode.Hypermedia.MediaTypeFormatters
{
    public class JsonHyperSchemaMediaTypeFormatter : BufferedMediaTypeFormatter
    {
        public JsonHyperSchemaMediaTypeFormatter()
            : base()
        {
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/schema+json"));
        }

        public override bool CanReadType(Type type)
        {
            return type.BaseType == typeof(HypermediaResource);
        }

        public override bool CanWriteType(Type type)
        {
            return type.BaseType == typeof(HypermediaResource);
        }

        public override object ReadFromStream(Type type, System.IO.Stream readStream, System.Net.Http.HttpContent content, IFormatterLogger formatterLogger)
        {
            var value = (HypermediaResource)Activator.CreateInstance(type);
            // Get the preferred character encoding based on information in the request
            //Encoding effectiveEncoding = SelectCharacterEncoding(content.Headers);
            string json;
            // Create a stream reader and read the content synchronously
            using (StreamReader sReader = new StreamReader(readStream))
            {
                json = sReader.ReadToEnd();
            }

            value = JsonConvert.DeserializeObject<HypermediaResource>(json);

            return value;
        }

        public override void WriteToStream(Type type, object value, System.IO.Stream writeStream, System.Net.Http.HttpContent content)
        {
            //Encoding effectiveEncoding = SelectCharacterEncoding(content.Headers);

            var jsonSchemaGenerator = new JsonSchemaGenerator();
            var myType = type;
            var schema = jsonSchemaGenerator.Generate(myType);
            schema.Title = myType.Name; // this doesn't seem to get done within the generator

            // You might not want to use the outer using statement that I have
            // I wasn't sure how long you would need the MemoryStream object
            using (StreamWriter sw = new StreamWriter(writeStream))
            {
                try
                {
                    sw.Write(schema);
                    sw.Flush();//otherwise you are risking empty stream
                }
                finally
                {
                    sw.Dispose();
                }
            }
        }
    }
}