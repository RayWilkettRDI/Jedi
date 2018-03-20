using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Gsm
{
    [Table("gsmBrandInformation")]
    public partial class GsmBrandInformation
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkLabelOwner", TypeName = "char(40)")]
        public string FkLabelOwner { get; set; }
        [Column("fkSpec", TypeName = "char(40)")]
        public string FkSpec { get; set; }
        [Column("fkTradingCompany", TypeName = "char(40)")]
        public string FkTradingCompany { get; set; }
        [Column("fkBrand", TypeName = "char(40)")]
        public string FkBrand { get; set; }
    }
}
