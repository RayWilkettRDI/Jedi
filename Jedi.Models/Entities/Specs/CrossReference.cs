using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.Specs
{
    [Table(name: "Cross_References", Schema = "pdm")]
    public class CrossReference
    {
        public string PKID { get; set; }
        public string SpecID { get; set; }
        public TradeSpec TradeSpec { get; set; }
        public string SystemName { get; set; }
        public string SystemCode { get; set; }
        public string Equivalent { get; set; }
        public string Name { get; set; }
    }
}
