using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Cacs
{
    [Table("CACSComplianceConstraint")]
    public partial class CacscomplianceConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkAttribute", TypeName = "char(40)")]
        public string FkAttribute { get; set; }
        public double? ConstraintValue { get; set; }
        public int? ConstraintOperator { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [Column("AttributeItemID", TypeName = "char(40)")]
        public string AttributeItemId { get; set; }
    }
}
