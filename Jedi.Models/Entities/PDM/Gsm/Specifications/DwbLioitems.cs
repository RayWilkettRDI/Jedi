using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm.Specifications
{
    [Table("dwbLIOItems")]
    public partial class DwbLioitems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("SourceTypeID", TypeName = "char(3)")]
        public string SourceTypeId { get; set; }
        [Column("fkBasis", TypeName = "char(40)")]
        public string FkBasis { get; set; }
        public double? PercentUsed { get; set; }
        [Column("fkContainer", TypeName = "char(40)")]
        public string FkContainer { get; set; }
        [StringLength(2048)]
        public string ListName { get; set; }
        [StringLength(2048)]
        public string ReconstituteName { get; set; }
        [Column("DisplayMethodID", TypeName = "char(2)")]
        public string DisplayMethodId { get; set; }
        [Column("fkExperiment", TypeName = "char(40)")]
        public string FkExperiment { get; set; }
        [Column("SourceID")]
        [StringLength(255)]
        public string SourceId { get; set; }
    }
}
