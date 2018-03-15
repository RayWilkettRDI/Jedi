using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmSpecOwners")]
    public partial class GsmSpecOwners
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpecSummary", TypeName = "char(40)")]
        public string FkSpecSummary { get; set; }
        [Column("OwnerID", TypeName = "char(40)")]
        public string OwnerId { get; set; }
    }
}
