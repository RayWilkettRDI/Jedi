using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmCombinedPrintPkgingAlts")]
    public partial class GsmCombinedPrintPkgingAlts
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("fkPrintPkgSpec", TypeName = "char(40)")]
        public string FkPrintPkgSpec { get; set; }
        public double? ScrapFactor { get; set; }
        [Column("UnitsTU")]
        [StringLength(25)]
        public string UnitsTu { get; set; }
        [StringLength(42)]
        public string Replaces { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public bool? IsCustomAssociation { get; set; }
        [Column("fkReplaces")]
        [StringLength(40)]
        public string FkReplaces { get; set; }
        [StringLength(4000)]
        public string Annotation { get; set; }
    }
}
