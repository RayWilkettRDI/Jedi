using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Global
{
    public partial class Countries
    {
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("CountryID")]
        [StringLength(50)]
        public string CountryId { get; set; }
        [Required]
        [StringLength(128)]
        public string Countryname { get; set; }
        [Column("LangID")]
        public int LangId { get; set; }
        [Column("ISOCode", TypeName = "nchar(2)")]
        public string Isocode { get; set; }
        public int? Status { get; set; }
        [Column("ISONumericCode", TypeName = "nchar(3)")]
        public string IsonumericCode { get; set; }
        public double? DexVersion { get; set; }
    }
}
