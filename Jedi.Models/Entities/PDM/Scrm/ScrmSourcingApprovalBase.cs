using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmSourcingApprovalBase")]
    public partial class ScrmSourcingApprovalBase
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFacilityID", TypeName = "char(40)")]
        public string FkFacilityId { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("fkPermissionTemplate", TypeName = "char(40)")]
        public string FkPermissionTemplate { get; set; }
        [Column("fkSecurityClassification", TypeName = "char(40)")]
        public string FkSecurityClassification { get; set; }
        public bool? IsTemplate { get; set; }
    }
}
