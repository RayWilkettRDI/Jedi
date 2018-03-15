using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class TimeZones
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Status { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        public double? DexVersion { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
