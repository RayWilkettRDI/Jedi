using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqModel")]
    public partial class EqModel
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(90)]
        public string Name { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("ModelTypeID")]
        [StringLength(5)]
        public string ModelTypeId { get; set; }
        [Column("fkSourcingApproval", TypeName = "char(40)")]
        public string FkSourcingApproval { get; set; }
    }
}
