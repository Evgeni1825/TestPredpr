using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models.Predpr
{
    public class Nsi00219
    {
        public Guid Nsi00219Id { get; set; }
        public string vnsostk { get; set; }
        public int nsi00219 { get; set; }
        public int nksost { get; set; }
        public int FactoryForeignKey { get; set; }
        public Factory Factory { get; set; }

    }
}
