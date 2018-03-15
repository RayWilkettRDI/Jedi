using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("LWFActivityOwnerConfigs")]
    public partial class LwfactivityOwnerConfigs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkActivityTemplate", TypeName = "char(40)")]
        public string FkActivityTemplate { get; set; }
        public int? Usage { get; set; }
    }
}
