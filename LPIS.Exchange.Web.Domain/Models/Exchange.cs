using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LPIS.Exchange.Web.Domain.Models
{
    public class Exchanges
    {
        [JsonProperty("rates")]
        public Array[] Rates { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
    }

}
