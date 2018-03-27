using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Pqs
{
    [Table("PQSSampleType")]
    public partial class PqssampleType
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("ID", TypeName = "char(2)")]
        public string Id { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
