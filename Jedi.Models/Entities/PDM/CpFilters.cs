using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cpFilters")]
    public partial class CpFilters
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("fkProfile", TypeName = "char(40)")]
        public string FkProfile { get; set; }
        [Required]
        [Column("criterionKey")]
        [StringLength(256)]
        public string CriterionKey { get; set; }
        [Required]
        [Column("operatorKey")]
        [StringLength(30)]
        public string OperatorKey { get; set; }
        [Required]
        [Column("operands")]
        [StringLength(1048)]
        public string Operands { get; set; }
        [Required]
        [Column("operandNames")]
        [StringLength(1048)]
        public string OperandNames { get; set; }
    }
}
