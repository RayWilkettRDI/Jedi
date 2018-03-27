using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonConfigurationName")]
    public partial class CommonConfigurationName
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("UILabel")]
        [StringLength(1000)]
        public string Uilabel { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string Tags { get; set; }
        [StringLength(1000)]
        public string RegexPattern { get; set; }
        public bool IsEncrypted { get; set; }
        [Column("fkStartVersion", TypeName = "char(40)")]
        public string FkStartVersion { get; set; }
        [Column("fkEndVersion", TypeName = "char(40)")]
        public string FkEndVersion { get; set; }
        public bool IsVersionLocked { get; set; }
        [Required]
        [Column("fkConfigurationType", TypeName = "char(40)")]
        public string FkConfigurationType { get; set; }
        public int Status { get; set; }
        public int NodeType { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
