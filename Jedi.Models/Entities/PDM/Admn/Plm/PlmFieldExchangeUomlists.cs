using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmFieldExchangeUOMLists")]
    public partial class PlmFieldExchangeUomlists
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUOMNamedList", TypeName = "char(40)")]
        public string FkUomnamedList { get; set; }
    }
}
