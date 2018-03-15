using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comStandardNutrientProperties")]
    public partial class ComStandardNutrientProperties
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("GSMID")]
        [StringLength(32)]
        public string Gsmid { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkDefaultUOM", TypeName = "char(40)")]
        public string FkDefaultUom { get; set; }
        [Column("InFoodsID")]
        [StringLength(24)]
        public string InFoodsId { get; set; }
        [Column("UNID")]
        [StringLength(10)]
        public string Unid { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
