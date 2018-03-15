using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jedi.Models.Entities.PDM
{
    [Table("ORNamespaceMetaInfo")]
    public partial class OrnamespaceMetaInfo
    {
        [Key]
        [Column("pkid", TypeName = "char(40)")]
        public string Pkid { get; set; }
        [Required]
        [Column("namespace")]
        [StringLength(100)]
        public string Namespace { get; set; }
        [Required]
        [Column("enumname")]
        [StringLength(75)]
        public string Enumname { get; set; }
        [Column("startgroupseed")]
        public int Startgroupseed { get; set; }
        [Column("maxgroupseed")]
        public int Maxgroupseed { get; set; }
        [Column("assemblyname")]
        [StringLength(50)]
        public string Assemblyname { get; set; }
    }
}
