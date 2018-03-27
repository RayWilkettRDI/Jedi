using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonCurrencyConversionRates")]
    public partial class CommonCurrencyConversionRates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkConversionTimeFrame", TypeName = "char(40)")]
        public string FkConversionTimeFrame { get; set; }
        [Column("fkCurrency", TypeName = "char(40)")]
        public string FkCurrency { get; set; }
        [Column("baseConversionRate")]
        public double? BaseConversionRate { get; set; }
    }
}
