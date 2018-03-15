using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("FCLSource")]
    public partial class Fclsource
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(48)]
        public string Name { get; set; }
        [Column("SourceID")]
        [StringLength(24)]
        public string SourceId { get; set; }
        public int Status { get; set; }
    }
}
