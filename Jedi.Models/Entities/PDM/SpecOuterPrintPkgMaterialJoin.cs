using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specOuterPrintPkgMaterialJoin")]
    public partial class SpecOuterPrintPkgMaterialJoin
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        public double? ScrapFactor { get; set; }
        public double? Units { get; set; }
        [Column("fkPrintPkgSpec", TypeName = "char(40)")]
        public string FkPrintPkgSpec { get; set; }
        [Column("fkUOMCategory", TypeName = "char(40)")]
        public string FkUomcategory { get; set; }
        [Column("annotation")]
        [StringLength(100)]
        public string Annotation { get; set; }
        [Column("sortOrder")]
        public int? SortOrder { get; set; }
        public bool? IsCustomAssociation { get; set; }
    }
}
