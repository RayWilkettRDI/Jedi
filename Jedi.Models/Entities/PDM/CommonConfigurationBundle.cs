using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonConfigurationBundle")]
    public partial class CommonConfigurationBundle
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [Column("fkConfigurationReleaseVersion", TypeName = "char(40)")]
        public string FkConfigurationReleaseVersion { get; set; }
        [Required]
        [Column("fkConfigurationEnvironment", TypeName = "char(40)")]
        public string FkConfigurationEnvironment { get; set; }
        public int Status { get; set; }
    }
}
