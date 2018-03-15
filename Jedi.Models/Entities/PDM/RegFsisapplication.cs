using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("regFSISApplication")]
    public partial class RegFsisapplication
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string ApprovalNumber { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        [Column(TypeName = "char(7)")]
        public string SpecNumber { get; set; }
        [Column("fkApplicationType", TypeName = "char(40)")]
        public string FkApplicationType { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column(TypeName = "ntext")]
        public string Comments { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column(TypeName = "ntext")]
        public string ProcessingProcedure { get; set; }
        [Column(TypeName = "ntext")]
        public string ProductFormula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(512)]
        public string FrenchName { get; set; }
        [Column("approvalDate", TypeName = "datetime")]
        public DateTime? ApprovalDate { get; set; }
        [Column("fkFormulationContext", TypeName = "char(40)")]
        public string FkFormulationContext { get; set; }
    }
}
