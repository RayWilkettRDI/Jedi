using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Nsm
{
    [Table("nsmNutrientAnalysis")]
    public partial class NsmNutrientAnalysis
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkSourceFacility", TypeName = "char(40)")]
        public string FkSourceFacility { get; set; }
        [Column("fkExternalReference", TypeName = "char(40)")]
        public string FkExternalReference { get; set; }
        [Column("description")]
        [StringLength(1024)]
        public string Description { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [Column("analysisDate", TypeName = "datetime")]
        public DateTime? AnalysisDate { get; set; }
        [Column("analysisNumber", TypeName = "nchar(8)")]
        public string AnalysisNumber { get; set; }
        [StringLength(50)]
        public string SampleType { get; set; }
        [StringLength(50)]
        public string SampleNumber { get; set; }
        [Column("GTINUPC")]
        [StringLength(14)]
        public string Gtinupc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedFromLab { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SentToLab { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        [Column("fkContext", TypeName = "char(40)")]
        public string FkContext { get; set; }
    }
}
