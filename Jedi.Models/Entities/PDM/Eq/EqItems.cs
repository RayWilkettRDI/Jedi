using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Eq
{
    [Table("eqItems")]
    public partial class EqItems
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Options { get; set; }
        [Column("fkAffilatedDataObject")]
        [StringLength(40)]
        public string FkAffilatedDataObject { get; set; }
        public int? SequenceNumber { get; set; }
        [StringLength(90)]
        public string ItemKey { get; set; }
        [Column("fkParent", TypeName = "char(40)")]
        public string FkParent { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        [Column("subOptions")]
        public int SubOptions { get; set; }
    }
}
