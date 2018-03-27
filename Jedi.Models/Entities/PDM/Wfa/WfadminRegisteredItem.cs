using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Wfa
{
    [Table("WFAdminRegisteredItem")]
    public partial class WfadminRegisteredItem
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("val")]
        [StringLength(2000)]
        public string Val { get; set; }
        [Column("type")]
        public int Type { get; set; }
    }
}
