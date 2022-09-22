using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LocalJson
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Holidays
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long? Code { get; set; }

        [JsonProperty("holiday", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string,HolidayValue> Holiday { get; set; }
    }

    public partial class HolidayValue
    {
        [JsonProperty("holiday", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Holiday { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("after", NullValueHandling = NullValueHandling.Ignore)]
        public bool? After { get; set; }

        [JsonProperty("wage", NullValueHandling = NullValueHandling.Ignore)]
        public long? Wage { get; set; }

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }
    }
}
