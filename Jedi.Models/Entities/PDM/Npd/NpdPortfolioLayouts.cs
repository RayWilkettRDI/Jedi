using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdPortfolioLayouts")]
    public partial class NpdPortfolioLayouts
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkPortfolio", TypeName = "char(40)")]
        public string FkPortfolio { get; set; }
        [Column("sequenceNumber")]
        public int? SequenceNumber { get; set; }
        [Column("fkLayoutDefinition", TypeName = "char(40)")]
        public string FkLayoutDefinition { get; set; }
    }
}
