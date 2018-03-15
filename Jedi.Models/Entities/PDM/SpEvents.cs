using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("spEvents")]
    public partial class SpEvents
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
        [Column("fkSupplierRep", TypeName = "char(40)")]
        public string FkSupplierRep { get; set; }
        [Column("fkCompany", TypeName = "char(40)")]
        public string FkCompany { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [Column("fkEventText", TypeName = "char(40)")]
        public string FkEventText { get; set; }
        [Column("fkFacility", TypeName = "char(40)")]
        public string FkFacility { get; set; }
        [StringLength(2000)]
        public string Comments { get; set; }
    }
}
