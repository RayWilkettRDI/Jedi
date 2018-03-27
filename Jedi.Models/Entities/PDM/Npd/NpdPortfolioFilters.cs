using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Npd
{
    [Table("npdPortfolioFilters")]
    public partial class NpdPortfolioFilters
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkProjectPortfolio", TypeName = "char(40)")]
        public string FkProjectPortfolio { get; set; }
        [StringLength(256)]
        public string Value { get; set; }
        [StringLength(30)]
        public string SubAttributeKey { get; set; }
    }
}
