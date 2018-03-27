using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmRelatedPackingConfig")]
    public partial class GsmRelatedPackingConfig
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkPackingConfig", TypeName = "char(40)")]
        public string FkPackingConfig { get; set; }
        [StringLength(20)]
        public string Equivalent { get; set; }
        [StringLength(256)]
        public string Comments { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
    }
}
