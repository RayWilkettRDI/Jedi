using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonDataGroupMapping")]
    public partial class CommonDataGroupMapping
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkDataGroup", TypeName = "char(40)")]
        public string FkDataGroup { get; set; }
        [Column("fkSpecType", TypeName = "char(4)")]
        public string FkSpecType { get; set; }
        public double? DexVersion { get; set; }
    }
}
