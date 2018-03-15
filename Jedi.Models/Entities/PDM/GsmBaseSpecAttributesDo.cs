using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmBaseSpecAttributesDO")]
    public partial class GsmBaseSpecAttributesDo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkBasisParent", TypeName = "char(40)")]
        public string FkBasisParent { get; set; }
        [Column("fkExperimentParent", TypeName = "char(40)")]
        public string FkExperimentParent { get; set; }
    }
}
