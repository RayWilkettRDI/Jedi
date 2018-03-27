using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditCustomAttributes")]
    public partial class AuditCustomAttributes
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("attributeType")]
        [StringLength(128)]
        public string AttributeType { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("attributeNamespace")]
        [StringLength(1024)]
        public string AttributeNamespace { get; set; }
        [Column("attributeName")]
        [StringLength(256)]
        public string AttributeName { get; set; }
        [Column("attributeValue")]
        [StringLength(256)]
        public string AttributeValue { get; set; }
    }
}
