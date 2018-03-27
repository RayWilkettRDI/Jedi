using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqDrlDocsDO")]
    public partial class EqDrlDocsDo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [StringLength(512)]
        public string Comments { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [Column("fkDocumentLibItem", TypeName = "char(40)")]
        public string FkDocumentLibItem { get; set; }
        [Column(TypeName = "char(4)")]
        public string DeliveryMethod { get; set; }
    }
}
