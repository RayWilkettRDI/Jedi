using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmRelatedPackaging")]
    public partial class GsmRelatedPackaging
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public double? Units { get; set; }
        [Column("fkPackagingLevel", TypeName = "char(40)")]
        public string FkPackagingLevel { get; set; }
        [Column("fkRelatedPackage", TypeName = "char(40)")]
        public string FkRelatedPackage { get; set; }
        [Column("fkUOMCategory", TypeName = "char(40)")]
        public string FkUomcategory { get; set; }
        public double? ScrapFactor { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [StringLength(100)]
        public string Comments { get; set; }
        public int? Sequence { get; set; }
        public bool IsCustomAssociation { get; set; }
        [StringLength(4000)]
        public string Annotation { get; set; }
    }
}
