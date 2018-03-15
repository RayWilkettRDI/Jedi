using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cpProfiles")]
    public partial class CpProfiles
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("label")]
        [StringLength(50)]
        public string Label { get; set; }
        [Column("description")]
        [StringLength(2048)]
        public string Description { get; set; }
        [Required]
        [Column("fkView", TypeName = "char(40)")]
        public string FkView { get; set; }
        [Required]
        [Column("fkPortal", TypeName = "char(40)")]
        public string FkPortal { get; set; }
        [Column("status")]
        public int Status { get; set; }
    }
}
