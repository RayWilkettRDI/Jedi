using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonSubstituteLookups")]
    public partial class CommonSubstituteLookups
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string Namespace { get; set; }
        [StringLength(1024)]
        public string OriginalValue { get; set; }
        [StringLength(1024)]
        public string SubstituteValue { get; set; }
    }
}
