using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("DWBSpecStatus")]
    public partial class DwbspecStatus
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? IsActionable { get; set; }
        public int? Status { get; set; }
        public double? DexVersion { get; set; }
    }
}
