using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmAttributeRangeItemML")]
    public partial class GsmAttributeRangeItemMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkRangeItem", TypeName = "char(40)")]
        public string FkRangeItem { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
