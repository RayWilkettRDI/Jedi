using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("GSMSuccessionRequest")]
    public partial class GsmsuccessionRequest
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column(TypeName = "nchar(7)")]
        public string RequestNumber { get; set; }
        public bool? IsComplete { get; set; }
        [Column("fkNewSpecification", TypeName = "char(40)")]
        public string FkNewSpecification { get; set; }
        public int? SuccessionSpecType { get; set; }
        public bool? HasBeenStarted { get; set; }
        [Column("fkBusinessUnitScope", TypeName = "char(40)")]
        public string FkBusinessUnitScope { get; set; }
        [Column("fkSpecToSupersede", TypeName = "char(40)")]
        public string FkSpecToSupersede { get; set; }
        [Column("fkCreator", TypeName = "char(40)")]
        public string FkCreator { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastSavedDate { get; set; }
        public int? ParentSpecType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("reason")]
        [StringLength(256)]
        public string Reason { get; set; }
        public bool? SearchCriterion { get; set; }
    }
}
