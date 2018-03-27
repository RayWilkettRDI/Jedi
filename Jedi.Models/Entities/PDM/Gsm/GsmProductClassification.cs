using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmProductClassification")]
    public partial class GsmProductClassification
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkTaxType", TypeName = "char(40)")]
        public string FkTaxType { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        public double? TaxRate { get; set; }
        [Column("fkManufacturer", TypeName = "char(40)")]
        public string FkManufacturer { get; set; }
        [Column("fkInfoProvider", TypeName = "char(40)")]
        public string FkInfoProvider { get; set; }
        public bool? IsSyndicated { get; set; }
        [Column("UNSPSCCode")]
        [StringLength(8)]
        public string Unspsccode { get; set; }
        [Column("fkUNSPSCTaxonomy", TypeName = "char(40)")]
        public string FkUnspsctaxonomy { get; set; }
        [Column("fkGPCTaxonomy", TypeName = "char(40)")]
        public string FkGpctaxonomy { get; set; }
        [Column("fkUDEXTaxonomy", TypeName = "char(40)")]
        public string FkUdextaxonomy { get; set; }
    }
}
