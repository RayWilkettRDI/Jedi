using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    public partial class Address
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("street1")]
        [StringLength(100)]
        public string Street1 { get; set; }
        [Column("street2")]
        [StringLength(100)]
        public string Street2 { get; set; }
        [Column("city")]
        [StringLength(100)]
        public string City { get; set; }
        [Column("state")]
        [StringLength(100)]
        public string State { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        [Column("fkPerson", TypeName = "char(40)")]
        public string FkPerson { get; set; }
        [Column("street3")]
        [StringLength(100)]
        public string Street3 { get; set; }
        [Column("street4")]
        [StringLength(100)]
        public string Street4 { get; set; }
        [StringLength(100)]
        public string PostalCode { get; set; }
        [Column("fkUser", TypeName = "char(40)")]
        public string FkUser { get; set; }
    }
}
