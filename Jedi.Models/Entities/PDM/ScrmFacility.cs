using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("scrmFacility")]
    public partial class ScrmFacility
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkCompany", TypeName = "char(40)")]
        public string FkCompany { get; set; }
        [Column("fkstatus", TypeName = "char(40)")]
        public string Fkstatus { get; set; }
        [Column("fkCountry", TypeName = "char(40)")]
        public string FkCountry { get; set; }
        [Column(TypeName = "char(7)")]
        public string Num { get; set; }
        [Column("lasteditdt", TypeName = "datetime")]
        public DateTime? Lasteditdt { get; set; }
        [Column("website")]
        [StringLength(256)]
        public string Website { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("fkOriginator", TypeName = "char(40)")]
        public string FkOriginator { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        public bool? IsTemplate { get; set; }
        [Column("fkOriginatingTemplate", TypeName = "char(40)")]
        public string FkOriginatingTemplate { get; set; }
        public bool? Archived { get; set; }
    }
}
