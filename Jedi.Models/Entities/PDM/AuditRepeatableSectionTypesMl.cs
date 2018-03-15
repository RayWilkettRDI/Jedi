using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("auditRepeatableSectionTypesML")]
    public partial class AuditRepeatableSectionTypesMl
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("description")]
        [StringLength(1024)]
        public string Description { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
    }
}
