using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("CACSConstraintItem")]
    public partial class CacsconstraintItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? ConstraintOperator { get; set; }
        public double? ConstraintValue { get; set; }
    }
}
