using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Predpr
{
    public class Nsi00212
    {
        public Guid Nsi00212Id { get; set; }
        public int nkuz { get; set; }
        public string vnuzp { get; set; }
        public int nsi00212 { get; set; }
        public int FactoryForeignKey { get; set; }
        public Factory Factory { get; set; }

    }
}
