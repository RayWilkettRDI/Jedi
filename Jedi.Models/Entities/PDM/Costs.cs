using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Costs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkPerValueUOM", TypeName = "char(40)")]
        public string FkPerValueUom { get; set; }
        public double? PerValueQuantity { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
        public double? Price { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
