using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("DataAdminToolkit_VersionHist")]
    public partial class DataAdminToolkitVersionHist
    {
        [Key]
        [Column("pkid", TypeName = "char(36)")]
        public string Pkid { get; set; }
        [Column("createdt", TypeName = "datetime")]
        public DateTime? Createdt { get; set; }
        [Column("executedt", TypeName = "datetime")]
        public DateTime? Executedt { get; set; }
    }
}
