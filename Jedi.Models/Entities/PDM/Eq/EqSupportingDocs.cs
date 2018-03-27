using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqSupportingDocs")]
    public partial class EqSupportingDocs
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(512)]
        public string Comments { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column(TypeName = "char(4)")]
        public string DeliveryMethod { get; set; }
        [Column("fkDocLibItem", TypeName = "char(40)")]
        public string FkDocLibItem { get; set; }
    }
}
