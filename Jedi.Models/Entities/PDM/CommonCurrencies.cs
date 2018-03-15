using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonCurrencies")]
    public partial class CommonCurrencies
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("USDConversionFactor")]
        public double? UsdconversionFactor { get; set; }
        [Column("ISOCode")]
        [StringLength(3)]
        public string Isocode { get; set; }
    }
}
