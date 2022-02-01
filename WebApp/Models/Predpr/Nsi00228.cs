using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Predpr
{
    public class Nsi00228
    {
        public Guid Nsi00228Id { get; set; }
        public int nkslkv { get; set; }
        public string vnslkvp { get; set; }
        public int nsi00228 { get; set; }
        public int FactoryForeignKey { get; set; }
        public Factory Factory { get; set; }
    }
}
