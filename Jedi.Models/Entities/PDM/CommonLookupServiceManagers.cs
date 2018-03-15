using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonLookupServiceManagers")]
    public partial class CommonLookupServiceManagers
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string FactoryClassname { get; set; }
        [Column("ManagerID")]
        [StringLength(64)]
        public string ManagerId { get; set; }
        [StringLength(550)]
        public string ConfigValues { get; set; }
        public bool? Private { get; set; }
        public double? DexVersion { get; set; }
    }
}
