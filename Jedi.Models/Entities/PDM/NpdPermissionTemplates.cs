using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("npdPermissionTemplates")]
    public partial class NpdPermissionTemplates
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        public bool? Private { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(75)]
        public string Name { get; set; }
        [Column(TypeName = "char(4)")]
        public string Type { get; set; }
    }
}
