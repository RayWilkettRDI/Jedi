using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdStageMasters")]
    public partial class NpdStageMasters
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("isGatekeeperRequired")]
        public bool? IsGatekeeperRequired { get; set; }
    }
}
