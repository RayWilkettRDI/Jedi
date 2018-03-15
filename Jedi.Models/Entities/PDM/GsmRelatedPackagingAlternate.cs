using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmRelatedPackagingAlternate")]
    public partial class GsmRelatedPackagingAlternate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkRelatedPackage", TypeName = "char(40)")]
        public string FkRelatedPackage { get; set; }
        [Column(TypeName = "char(11)")]
        public string Replaces { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        public double? Units { get; set; }
        public double? ScrapFactor { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public bool IsCustomAssociation { get; set; }
        public int Sequence { get; set; }
        [Column("fkReplaces")]
        [StringLength(40)]
        public string FkReplaces { get; set; }
        [StringLength(4000)]
        public string Annotation { get; set; }
    }
}
