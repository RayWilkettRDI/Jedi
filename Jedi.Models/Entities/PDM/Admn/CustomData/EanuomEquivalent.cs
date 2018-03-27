using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.CustomData
{
    [Table("EANUomEquivalent")]
    public partial class EanuomEquivalent
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("ISO")]
        [StringLength(3)]
        public string Iso { get; set; }
        [Column("fkUOM", TypeName = "char(40)")]
        public string FkUom { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
    }
}
