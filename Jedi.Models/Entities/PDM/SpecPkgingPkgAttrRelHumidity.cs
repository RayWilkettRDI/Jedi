using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("specPkgingPkgAttrRelHumidity")]
    public partial class SpecPkgingPkgAttrRelHumidity
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("relativehumidity")]
        [StringLength(100)]
        public string Relativehumidity { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Required]
        [Column("fkParentID", TypeName = "char(40)")]
        public string FkParentId { get; set; }
    }
}
