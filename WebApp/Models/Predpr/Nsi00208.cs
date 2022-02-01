using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Predpr
{
    public class Nsi00208
    {
        public Guid Nsi00208Id { get; set; }
        public int nkscrt { get; set; }
        public string vnscrtp { get; set; }
        public int nsi00208 { get; set; }
        public int FactoryForeignKey { get; set; }
        public Factory Factory { get; set; }
    }
}
