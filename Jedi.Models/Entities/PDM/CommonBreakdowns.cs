using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonBreakdowns")]
    public partial class CommonBreakdowns
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("creationdate", TypeName = "datetime")]
        public DateTime? Creationdate { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        public bool? PubToSupplierPortal { get; set; }
        [Column("isMasterFormula")]
        public bool? IsMasterFormula { get; set; }
        [Column("isProprietary")]
        public bool? IsProprietary { get; set; }
        public bool? IsRegulatory { get; set; }
    }
}
