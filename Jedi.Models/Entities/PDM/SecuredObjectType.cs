using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("securedObjectType")]
    public partial class SecuredObjectType
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("typeId")]
        public int TypeId { get; set; }
        [Column("fkDefaultClassification", TypeName = "char(40)")]
        public string FkDefaultClassification { get; set; }
        [Column("isSecurityMandatory")]
        public bool IsSecurityMandatory { get; set; }
    }
}
