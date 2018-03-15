using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specOuterPkgMaterialJoin")]
    public partial class SpecOuterPkgMaterialJoin
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Required]
        [Column("fkPkgSpec", TypeName = "char(40)")]
        public string FkPkgSpec { get; set; }
        [Column("UnitsCS")]
        public double? UnitsCs { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        public double? Units { get; set; }
        public double? ScrapFactor { get; set; }
        [Column("fkUOMCategory", TypeName = "char(40)")]
        public string FkUomcategory { get; set; }
        [Column("sortOrder")]
        public int? SortOrder { get; set; }
        [Column("annotation")]
        [StringLength(100)]
        public string Annotation { get; set; }
        public bool? IsCustomAssociation { get; set; }
        public bool? IsCostOverridden { get; set; }
        [Column("fkPackSize", TypeName = "char(40)")]
        public string FkPackSize { get; set; }
    }
}
