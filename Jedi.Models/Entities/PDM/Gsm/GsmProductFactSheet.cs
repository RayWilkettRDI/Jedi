using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmProductFactSheet")]
    public partial class GsmProductFactSheet
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSupportingDocument", TypeName = "char(40)")]
        public string FkSupportingDocument { get; set; }
        [Column("notes", TypeName = "ntext")]
        public string Notes { get; set; }
    }
}
