using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Nsm
{
    [Table("nsmNutrientAnalysisML")]
    public partial class NsmNutrientAnalysisMl
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("langID")]
        public int LangId { get; set; }
        [Column("fkAnalysis", TypeName = "char(40)")]
        public string FkAnalysis { get; set; }
        [Column("description")]
        [StringLength(1024)]
        public string Description { get; set; }
    }
}
