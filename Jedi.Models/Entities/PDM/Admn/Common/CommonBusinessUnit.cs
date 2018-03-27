using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Admn.Common
{
    [Table("commonBusinessUnit")]
    public partial class CommonBusinessUnit
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Column("fkBUNamespace", TypeName = "char(40)")]
        public string FkBunamespace { get; set; }
        [Column("fkBusinessUnit")]
        [StringLength(40)]
        public string FkBusinessUnit { get; set; }
        public int? Status { get; set; }
        public int IsPhantom { get; set; }
        [Column("ExternalID")]
        [StringLength(200)]
        public string ExternalId { get; set; }
    }
}
