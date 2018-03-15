using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("plmFieldExchangeUOMListML")]
    public partial class PlmFieldExchangeUomlistMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFieldExchangeUOMList", TypeName = "char(40)")]
        public string FkFieldExchangeUomlist { get; set; }
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
    }
}
