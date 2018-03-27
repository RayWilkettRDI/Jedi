using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmSourcingApprovalML")]
    public partial class ScrmSourcingApprovalMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(1250)]
        public string Notes { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkSourcingApproval", TypeName = "char(40)")]
        public string FkSourcingApproval { get; set; }
    }
}
