using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM.Css
{
    [Table("cssPublicationNamespace")]
    public partial class CssPublicationNamespace
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [StringLength(40)]
        public string InitialNonGhostActivity { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        public bool? Private { get; set; }
        [Column(TypeName = "char(4)")]
        public string SpecType { get; set; }
        public bool? DoChildrenTips { get; set; }
    }
}
