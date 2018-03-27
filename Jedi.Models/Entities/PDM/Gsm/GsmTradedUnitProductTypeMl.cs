using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmTradedUnitProductTypeML")]
    public partial class GsmTradedUnitProductTypeMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("fkTradedUnitProductType", TypeName = "char(40)")]
        public string FkTradedUnitProductType { get; set; }
    }
}
