using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Predpr
{
    public class Nsi00211
    {
        public Guid Nsi00211Id { get; set; }
        public int nkvob { get; set; }
        public string vnvobp { get; set; }
        public int nsi00211 { get; set; }
        public int FactoryForeignKey { get; set; }
        public Factory Factory { get; set; }

    }
}
