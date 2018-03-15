using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TheoreticalEnvWaste
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Required]
        [Column("fkEnvWaste", TypeName = "char(40)")]
        public string FkEnvWaste { get; set; }
        [Required]
        [Column("fkEnvWasteOverride", TypeName = "char(40)")]
        public string FkEnvWasteOverride { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
        public bool IsOverrideOnly { get; set; }
    }
}
