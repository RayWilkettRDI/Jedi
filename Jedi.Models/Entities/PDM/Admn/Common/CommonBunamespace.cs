using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonBUNamespace")]
    public partial class CommonBunamespace
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("NamespaceID")]
        [StringLength(30)]
        public string NamespaceId { get; set; }
        public double? DexVersion { get; set; }
    }
}
