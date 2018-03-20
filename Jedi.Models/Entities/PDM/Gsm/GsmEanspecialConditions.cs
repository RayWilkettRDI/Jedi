using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmEANSpecialConditions")]
    public partial class GsmEanspecialConditions
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Value { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
