using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace WebApp.Models.Predpr
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Factory
    {
        [Key]
        public int FactoryId { get; set; }

        [JsonProperty(PropertyName = "nsi00219")]
        public Nsi00219 nsi00219 { get; set; }

        [JsonProperty(PropertyName = "ngrn")]
        public int ngrn { get; set; }

        [JsonProperty(PropertyName = "dfrom")]
        public DateTime dfrom { get; set; }

        [JsonProperty(PropertyName = "dto")]
        public DateTime dto { get; set; }
        
        [JsonProperty(PropertyName = "nsi00208")]
        public Nsi00208 nsi00208 { get; set; }

        [JsonProperty(PropertyName = "nsi00212CRT")]
        public Nsi00212CRT nsi00212CRT { get; set; }

        [JsonProperty(PropertyName = "nsi00228")]
        public Nsi00228 nsi00228 { get; set; }

        [JsonProperty(PropertyName = "vnrlkv")]
        public string vnrlkv { get; set; }

        [JsonProperty(PropertyName = "nsi00212LKV")]
        public Nsi00212LKV nsi00212LKV { get; set; }

        [JsonProperty(PropertyName = "nsi00212")]
        public Nsi00212 nsi00212 { get; set; }

        [JsonProperty(PropertyName = "nsi00211")]
        public Nsi00211 nsi00211 { get; set; }

        public string vnaim { get; set; }
    }
}
