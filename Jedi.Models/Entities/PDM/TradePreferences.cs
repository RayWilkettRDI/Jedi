using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TradePreferences
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(250)]
        public string AttrName { get; set; }
        [StringLength(4000)]
        public string AttrValue { get; set; }
        [Column("fkAttrParentID")]
        [StringLength(40)]
        public string FkAttrParentId { get; set; }
    }
}
