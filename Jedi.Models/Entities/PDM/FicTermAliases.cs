using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ficTermAliases")]
    public partial class FicTermAliases
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? SequenceNumber { get; set; }
        [Column("fkTermParent")]
        [StringLength(40)]
        public string FkTermParent { get; set; }
        [Column("fkAliasParent")]
        [StringLength(40)]
        public string FkAliasParent { get; set; }
    }
}
