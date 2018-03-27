using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Plm
{
    [Table("plmAnalyticSeries")]
    public partial class PlmAnalyticSeries
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkFieldExchangeDefinition", TypeName = "char(40)")]
        public string FkFieldExchangeDefinition { get; set; }
        [Column("fkAnalytic", TypeName = "char(40)")]
        public string FkAnalytic { get; set; }
        [Column("seriesType")]
        public int? SeriesType { get; set; }
        [Column("sequenceNumber")]
        public int? SequenceNumber { get; set; }
    }
}
