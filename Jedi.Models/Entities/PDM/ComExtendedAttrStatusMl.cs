using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("comExtendedAttrStatusML")]
    public partial class ComExtendedAttrStatusMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkExtendedAttributeStatus", TypeName = "char(40)")]
        public string FkExtendedAttributeStatus { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
    }
}
