using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Cacs
{
    [Table("CACSExtAttributeConstraint")]
    public partial class CacsextAttributeConstraint
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? ConstraintOperator { get; set; }
        public int? ConstraintOperator2 { get; set; }
        public int? ConstraintOperator3 { get; set; }
        [Column("fkExtendedAttribute", TypeName = "char(40)")]
        public string FkExtendedAttribute { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        public int? Sequence { get; set; }
    }
}
