using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cpViews")]
    public partial class CpViews
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("newWindow")]
        public bool NewWindow { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Required]
        [Column("searchPluginLoader")]
        [StringLength(2048)]
        public string SearchPluginLoader { get; set; }
        [Required]
        [Column("renderingPluginLoader")]
        [StringLength(2048)]
        public string RenderingPluginLoader { get; set; }
        [Required]
        [Column("filterPluginLoader")]
        [StringLength(2048)]
        public string FilterPluginLoader { get; set; }
        public double? DexVersion { get; set; }
    }
}
