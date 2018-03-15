using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("GSMPermissionTemplItemColls")]
    public partial class GsmpermissionTemplItemColls
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkTemplate", TypeName = "char(40)")]
        public string FkTemplate { get; set; }
        public int? SequenceNumber { get; set; }
        public int? Action { get; set; }
    }
}
