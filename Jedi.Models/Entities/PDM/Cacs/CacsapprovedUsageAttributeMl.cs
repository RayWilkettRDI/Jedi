using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Cacs
{
    [Table("CACSApprovedUsageAttributeML")]
    public partial class CacsapprovedUsageAttributeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("fkAttribute", TypeName = "char(40)")]
        public string FkAttribute { get; set; }
    }
}
