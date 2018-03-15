using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("gsmStepCalcTypeLookupItemsML")]
    public partial class GsmStepCalcTypeLookupItemsMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(256)]
        public string Value { get; set; }
        [Column("fkParentLookupItem", TypeName = "char(40)")]
        public string FkParentLookupItem { get; set; }
    }
}
