using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Global
{
    public partial class DataGroup
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        public double? DexVersion { get; set; }
        public int? Status { get; set; }
    }
}
