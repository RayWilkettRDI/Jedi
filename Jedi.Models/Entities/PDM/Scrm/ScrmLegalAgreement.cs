using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Scrm
{
    [Table("scrmLegalAgreement")]
    public partial class ScrmLegalAgreement
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("lasteditdt", TypeName = "datetime")]
        public DateTime? Lasteditdt { get; set; }
        [Column("fkEntityID", TypeName = "char(40)")]
        public string FkEntityId { get; set; }
    }
}
