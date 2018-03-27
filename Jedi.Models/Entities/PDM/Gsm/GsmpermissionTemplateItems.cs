using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("GSMPermissionTemplateItems")]
    public partial class GsmpermissionTemplateItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1900)]
        public string SecondaryConditionParams { get; set; }
        [StringLength(1900)]
        public string PrimaryConditionParams { get; set; }
        [Column("fkPrimaryArgFactory", TypeName = "char(40)")]
        public string FkPrimaryArgFactory { get; set; }
        [Column("fkSecondaryArgFactory", TypeName = "char(40)")]
        public string FkSecondaryArgFactory { get; set; }
        public int? SequenceNumber { get; set; }
        [Column(TypeName = "text")]
        public string PrimaryConditionArgsParams { get; set; }
        [StringLength(1900)]
        public string SecondaryConditionArgsParams { get; set; }
        [Column("fkSecondaryCondition", TypeName = "char(40)")]
        public string FkSecondaryCondition { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fkPrimaryCondition", TypeName = "char(40)")]
        public string FkPrimaryCondition { get; set; }
    }
}
