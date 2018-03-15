using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comLWFExtendedBehaviorTemplate")]
    public partial class ComLwfextendedBehaviorTemplate
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("BehaviorID")]
        public int? BehaviorId { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
        [Required]
        [Column("fkType", TypeName = "char(40)")]
        public string FkType { get; set; }
        public bool? IsDistinct { get; set; }
    }
}
