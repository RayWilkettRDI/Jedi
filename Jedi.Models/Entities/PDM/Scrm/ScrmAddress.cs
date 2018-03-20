using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmAddress")]
    public partial class ScrmAddress
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        [StringLength(261)]
        public string StateOrProvince { get; set; }
        [StringLength(30)]
        public string PostalCode { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(100)]
        public string Street1 { get; set; }
        [StringLength(100)]
        public string Street2 { get; set; }
        [Column("fkPostalCountry", TypeName = "char(40)")]
        public string FkPostalCountry { get; set; }
        [StringLength(100)]
        public string PostalCity { get; set; }
        [StringLength(60)]
        public string PostalCode2 { get; set; }
        [StringLength(200)]
        public string Postal1 { get; set; }
        [StringLength(150)]
        public string PostalStateOrProvince { get; set; }
        [StringLength(200)]
        public string Postal2 { get; set; }
        [Column("isPostalAddressDifferent")]
        public bool? IsPostalAddressDifferent { get; set; }
    }
}
