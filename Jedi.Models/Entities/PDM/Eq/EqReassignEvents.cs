using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqReassignEvents")]
    public partial class EqReassignEvents
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkRequest", TypeName = "char(40)")]
        public string FkRequest { get; set; }
        [Required]
        [Column("fkManager", TypeName = "char(40)")]
        public string FkManager { get; set; }
        [Required]
        [Column("fkSupplierRep", TypeName = "char(40)")]
        public string FkSupplierRep { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EventDate { get; set; }
    }
}
