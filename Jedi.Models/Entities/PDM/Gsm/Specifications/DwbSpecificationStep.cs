using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("dwbSpecificationStep")]
    public partial class DwbSpecificationStep
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkStepQuantityUOM", TypeName = "char(40)")]
        public string FkStepQuantityUom { get; set; }
        [Column("fkParentSpec", TypeName = "char(40)")]
        public string FkParentSpec { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(2400)]
        public string Narrative { get; set; }
    }
}
