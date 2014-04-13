using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
// added for JSON
using System.Net.Http.Formatting;
using System.Web;
using Auth.Web.WebApi;
using WebApiContrib.Formatting.Jsonp;

namespace FormsAuthJSONPDemo2
{
    public class FormatterConfig
    {
        public static void RegisterFormatters(MediaTypeFormatterCollection formatters)
        {
            var jsonFormatter = formatters.JsonFormatter;
            jsonFormatter.SerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            // Insert the JSONP formatter in front of the standard JSON formatter.
            var jsonpFormatter = new JsonpFormatter();
            formatters.Insert(0, jsonpFormatter);
        }
    }
}