using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("EQTSearchCriteria")]
    public partial class EqtsearchCriteria
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkEQTSearchEntry", TypeName = "char(40)")]
        public string FkEqtsearchEntry { get; set; }
        [Column(TypeName = "ntext")]
        public string HiddenValue { get; set; }
        [StringLength(128)]
        public string PropertyKey { get; set; }
        [StringLength(64)]
        public string OperationText { get; set; }
        [StringLength(256)]
        public string PropertyText { get; set; }
        [Column(TypeName = "ntext")]
        public string TextValue { get; set; }
        [Column(TypeName = "char(2)")]
        public string OperationKey { get; set; }
        [Column(TypeName = "ntext")]
        public string ExtAttrValue { get; set; }
        [Column("UOM", TypeName = "char(40)")]
        public string Uom { get; set; }
        [Column(TypeName = "char(40)")]
        public string ExtAttrSectionRowValue { get; set; }
        [Column(TypeName = "char(40)")]
        public string ExtAttrSectionColumnValue { get; set; }
    }
}
