using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("commonExtendedAttributeStatus")]
    public partial class CommonExtendedAttributeStatus
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public int? Id { get; set; }
        public bool? Active { get; set; }
    }
}
