using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("UOMML")]
    public partial class Uomml
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        [StringLength(32)]
        public string Abbreviation { get; set; }
    }
}
