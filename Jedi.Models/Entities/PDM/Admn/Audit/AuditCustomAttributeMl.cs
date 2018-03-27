using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Audit
{
    [Table("auditCustomAttributeML")]
    public partial class AuditCustomAttributeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkCustomAttribute", TypeName = "char(40)")]
        public string FkCustomAttribute { get; set; }
        [Column("attributeTextValue")]
        [StringLength(256)]
        public string AttributeTextValue { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("attributeDescription")]
        [StringLength(1024)]
        public string AttributeDescription { get; set; }
    }
}
