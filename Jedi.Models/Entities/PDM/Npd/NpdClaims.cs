using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdClaims")]
    public partial class NpdClaims
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
