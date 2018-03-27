using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmSrcingApprChecklistItem")]
    public partial class ScrmSrcingApprChecklistItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateRequested { get; set; }
        [Column("fkAuthor", TypeName = "char(40)")]
        public string FkAuthor { get; set; }
        [Column("fkSourcingApprovalChecklist", TypeName = "char(40)")]
        public string FkSourcingApprovalChecklist { get; set; }
        [Column("fkStatus", TypeName = "char(40)")]
        public string FkStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastEditDate { get; set; }
        [Column("fkFunctionalUnit", TypeName = "char(40)")]
        public string FkFunctionalUnit { get; set; }
    }
}
