using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApp.Models.Predpr
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class NaimFactory
    {
        [JsonProperty(PropertyName = "ngrn")]
        public int ngrn { get; set; }

        [JsonProperty(PropertyName = "vnaim")]
        public string vnaim { get; set; }
    }
}
