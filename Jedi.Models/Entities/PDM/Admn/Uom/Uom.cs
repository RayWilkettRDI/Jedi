using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Uom
{
    [Table("UOM")]
    public partial class Uom
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "char(2)")]
        public string Standard { get; set; }
        [Column("CvtFromBaseFormulaID")]
        public int? CvtFromBaseFormulaId { get; set; }
        public int? SortOrder { get; set; }
        [Column(TypeName = "char(2)")]
        public string Category { get; set; }
        [Column("CvtToBaseFormulaID")]
        public int? CvtToBaseFormulaId { get; set; }
        public double? Factor { get; set; }
        [Column("ID")]
        [StringLength(8)]
        public string Id { get; set; }
        [Column("ISOCode")]
        [StringLength(2)]
        public string Isocode { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
        public int? IsBase { get; set; }
    }
}
