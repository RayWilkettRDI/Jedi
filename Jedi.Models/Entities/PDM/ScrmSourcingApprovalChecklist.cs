using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("scrmSourcingApprovalChecklist")]
    public partial class ScrmSourcingApprovalChecklist
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSourcingApproval", TypeName = "char(40)")]
        public string FkSourcingApproval { get; set; }
        [Column("perioduntilred")]
        public int? Perioduntilred { get; set; }
        [Column("perioduntilamber")]
        public int? Perioduntilamber { get; set; }
    }
}
