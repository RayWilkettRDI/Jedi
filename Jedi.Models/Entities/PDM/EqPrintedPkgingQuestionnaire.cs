using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("eqPrintedPkgingQuestionnaire")]
    public partial class EqPrintedPkgingQuestionnaire
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        [StringLength(2400)]
        public string Description { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(128)]
        public string VarietyTitle { get; set; }
        [Column("SupplierPPkgNumber")]
        [StringLength(50)]
        public string SupplierPpkgNumber { get; set; }
        [Column("fkBrand", TypeName = "char(40)")]
        public string FkBrand { get; set; }
        [StringLength(2400)]
        public string Comments { get; set; }
    }
}
