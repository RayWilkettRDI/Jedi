using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class NutrientAnalysis
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Required]
        [Column("fldName")]
        [StringLength(128)]
        public string FldName { get; set; }
        [Column("nvalue")]
        [StringLength(50)]
        public string Nvalue { get; set; }
        [Column("notes")]
        [StringLength(50)]
        public string Notes { get; set; }
        [Column("uom")]
        [StringLength(50)]
        public string Uom { get; set; }
    }
}
