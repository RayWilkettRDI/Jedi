using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specAvailUOMJoin")]
    public partial class SpecAvailUomjoin
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecID", TypeName = "char(40)")]
        public string FkSpecId { get; set; }
        [Column("fkBaseUOM", TypeName = "char(40)")]
        public string FkBaseUom { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("derivedFactor")]
        public double? DerivedFactor { get; set; }
        [Column("baseFactor")]
        public double? BaseFactor { get; set; }
        public int? Status { get; set; }
    }
}
