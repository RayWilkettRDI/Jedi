using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    public partial class SpecLineageHistory
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSourceSpec", TypeName = "char(40)")]
        public string FkSourceSpec { get; set; }
        [Column("fkParticipantSpec", TypeName = "char(40)")]
        public string FkParticipantSpec { get; set; }
        [Required]
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        public int Action { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActivityDate { get; set; }
    }
}
