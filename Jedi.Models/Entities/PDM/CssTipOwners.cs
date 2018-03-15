using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("cssTipOwners")]
    public partial class CssTipOwners
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkOwner", TypeName = "char(40)")]
        public string FkOwner { get; set; }
        [Column("fkTradeItemPublication", TypeName = "char(40)")]
        public string FkTradeItemPublication { get; set; }
    }
}
