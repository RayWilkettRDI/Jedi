using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdAuditHistoryAssocUser")]
    public partial class NpdAuditHistoryAssocUser
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFunctionalArea", TypeName = "char(40)")]
        public string FkFunctionalArea { get; set; }
        [Column("fkAuditHistory", TypeName = "char(40)")]
        public string FkAuditHistory { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column(TypeName = "char(50)")]
        public string Role { get; set; }
    }
}
