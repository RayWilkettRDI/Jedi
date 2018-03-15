using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class ReconEquivTargets
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string DeclareAs { get; set; }
        public double? TargetValue { get; set; }
        [Column("fkCommonLookupTargetType", TypeName = "char(40)")]
        public string FkCommonLookupTargetType { get; set; }
        [StringLength(512)]
        public string Comments { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("ID", TypeName = "char(36)")]
        public string Id { get; set; }
    }
}
