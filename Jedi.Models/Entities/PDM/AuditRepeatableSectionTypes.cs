using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditRepeatableSectionTypes")]
    public partial class AuditRepeatableSectionTypes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("pboIdentifier", TypeName = "char(40)")]
        public string PboIdentifier { get; set; }
        [Column("identifier", TypeName = "char(1024)")]
        public string Identifier { get; set; }
    }
}
