using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cpPortals")]
    public partial class CpPortals
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("cacheTimeoutMinutes")]
        public int CacheTimeoutMinutes { get; set; }
        [Column("status")]
        public int Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
